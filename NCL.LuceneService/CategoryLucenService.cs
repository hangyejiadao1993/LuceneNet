using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Lucene.Net.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NCL.Entity;
using NCL.Helper;
using Directory = System.IO.Directory;

namespace NCL.LuceneService
{
    public class CategoryLucenService
    {
        public async Task<bool> AddCategory(Category category)
        {
            using (DbContext ctx = new advanced7Context())
            {
                await ctx.AddAsync(category);
                using (IndexWriter writer = GetCategoryIndexWriter())
                {
                    writer.AddDocument(GetCategoryDoc(category));
                    writer.Flush(false, false);
                    return await ctx.SaveChangesAsync() > 0;
                }
            }
        }


        public async Task<bool> UpdateCategory(Category category)
        {
            using (DbContext ctx = new advanced7Context())
            {
                ctx.Set<Category>().Update(category);
                using (var writer = GetCategoryIndexWriter())
                {
                    writer.UpdateDocument(new Term("Id", category.Id.ToString()), GetCategoryDoc(category));

                    return await ctx.SaveChangesAsync() > 0;
                }
            }
        }

        public async Task InitIndex()
        {
            using (DbContext ctx = new advanced7Context())
            {
                using (var writer = GetCategoryIndexWriter())
                {
                    var entices = await ctx.Set<Category>().ToListAsync();
                    foreach (var item in entices)
                    {
                        writer.AddDocument(GetCategoryDoc(item));
                    }

                    writer.Flush(false, false);
                }
            }
        }


        private Document GetCategoryDoc(Category item)
        {
            Document doc = new Document();
            doc.AddInt32Field("Id", item.Id, Field.Store.YES);
            doc.AddStringField("Name", item.Name, Field.Store.YES);
            doc.AddStringField("Code", item.Code, Field.Store.YES);
            doc.AddStringField("Id", item.ParentCode, Field.Store.YES);
            doc.AddInt32Field("State", item.State ?? 0, Field.Store.YES);
            doc.AddStringField("Url", item.Url, Field.Store.YES);
            doc.AddInt32Field("CategoryLevel", item.CategoryLevel ?? 0,
                Field.Store.YES);

            return doc;
        }


        private IndexWriter GetCategoryIndexWriter()
        {
            var Lucenversion = LuceneVersion.LUCENE_48;
            var IndexPath = AppContext.BaseDirectory +
                            ConfigHelper.GetInstance(StaticConst.AppSettings).GetValue(StaticConst.IndexPath) +
                            "/" + ConfigHelper.GetInstance(StaticConst.AppSettings)
                                .GetValue(StaticConst.CategoryIndexPath);
            var dir = new DirectoryInfo(IndexPath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(IndexPath);
            }

            FSDirectory category = FSDirectory.Open(dir);
            var analyzer = new StandardAnalyzer(Lucenversion);
            IndexWriter writer = new IndexWriter(category, new IndexWriterConfig(Lucenversion, analyzer));
            return writer;
        }

        public IList<Category> GetCagegory(int Level)
        {
            using (var indexwriter = GetCategoryIndexWriter())
            {
                var query = NumericRangeQuery.NewInt32Range("CategoryLevel", Level, Level, true, true);
                var searcher = new IndexSearcher(indexwriter.GetReader(applyAllDeletes: true));
                var hits = searcher.Search(query, Int32.MaxValue).ScoreDocs;
                IList<Category> list = new List<Category>();
                foreach (var hit in hits)
                {
                    var foundDoc = searcher.Doc(hit.Doc);
                    list.Add(
                        DocumentToCategory(foundDoc)
                    );
                }

                return list;
            }
        }
        
        
            
        
        
        

        private Category DocumentToCategory(Document foundDoc)
        {
            Category entity = new Category()
            {
                Id = int.Parse(foundDoc.Get("Id")),
                Name = foundDoc.Get("Name"),
                Code = foundDoc.Get("Code"),
                ParentCode = foundDoc.Get("ParentCode"),
                CategoryLevel = int.Parse(foundDoc.Get("CategoryLevel")),
                State = int.Parse(foundDoc.Get("State")),
                Url = foundDoc.Get("Url")
            };
            return entity;
        }
    }
}