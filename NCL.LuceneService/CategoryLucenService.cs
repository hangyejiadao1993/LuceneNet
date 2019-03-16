using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
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
                var writer = GetCategoryIndexWriter();
                writer.AddDocument(GetCategoryDoc(category));
                writer.Flush(false,false);
                return await ctx.SaveChangesAsync() > 0;
            }
        }


        public async Task<bool> UpdateCategory(Category category)
        {
            using (DbContext ctx = new advanced7Context())
            {
                ctx.Set<Category>().Update(category);
                var writer = GetCategoryIndexWriter();
                writer.UpdateDocument(new Term("Id", category.Id.ToString()), GetCategoryDoc(category));

                return await ctx.SaveChangesAsync() > 0;
            }
        }

        public async Task InitIndex()
        {
            using (DbContext ctx = new advanced7Context())
            {
                var writer = GetCategoryIndexWriter();
                var entices = await ctx.Set<Category>().ToListAsync();
                foreach (var item in entices)
                {
                    writer.AddDocument(GetCategoryDoc(item));
                }

                writer.Flush(false, false);
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
            doc.AddInt32Field("CategoryLevel", item.CategoryLevel ?? 0, Field.Store.YES);
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

 
        
        
        
        
        
    }
}