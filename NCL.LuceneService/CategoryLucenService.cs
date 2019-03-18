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

        public IList<Category> GetCagegory(string Level)
        {
            var phrase = new MultiPhraseQuery();
            phrase.Add(new Term("Name", "书"));
            var indexwriter = GetCategoryIndexWriter();

            var searcher = new IndexSearcher(indexwriter.GetReader(applyAllDeletes: true));

            var phrase2 = new MultiPhraseQuery();


            var hits = searcher.Search(phrase, Int32.MaxValue).ScoreDocs;

            var hits2 = searcher.Search(phrase2, 40).ScoreDocs;

            IList<Category> list = new List<Category>();
            foreach (var hit in hits)
            {
                var foundDoc = searcher.Doc(hit.Doc);

                var Id = foundDoc.Get("Id");
                var Code = (foundDoc.Get("Code"));
                list.Add(new Category()
                {
                    Id = int.Parse(foundDoc.Get("Id")),
                    Name = foundDoc.Get("Name"),
                    Code = foundDoc.Get("Code"),
                    ParentCode = foundDoc.Get("ParentCode"),
                    CategoryLevel = int.Parse(foundDoc.Get("CategoryLevel")),
                    State = int.Parse(foundDoc.Get("State")),
                    Url = foundDoc.Get("Url")
                });
            }

            indexwriter.Dispose();
            return list;
        }
    }
}