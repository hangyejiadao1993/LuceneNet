using System;
using System.Collections;
using System.IO;
using Lucene.Net.Analysis;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Store;
using Lucene.Net.Util;
using NCL.Helper;
using NCL.LuceneService.Dto;
using Directory = System.IO.Directory;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NCL.Entity;
using Lucene.Net.Analysis.Standard;

namespace NCL.LuceneService
{
    public class CommodityLuceneService
    {
        #region MyRegion

        public void BuildIndex()
        {
            
        }

        #endregion


        #region 私有方法

        private Document GetDoc(Commodity entity)
        {
            Document doc = new Document();

            doc.AddTextField("Id", entity.Id.ToString(), Field.Store.YES);
            doc.AddTextField("ProductId", entity.ProductId.ToString(), Field.Store.YES);
            doc.AddTextField("CategoryId", entity.CategoryId.ToString(), Field.Store.YES);
            doc.AddTextField("Title", entity.Title.ToString(), Field.Store.YES);
            doc.AddDoubleField("Price", Double.Parse((entity.Price ?? (decimal) 0.00).ToString()), Field.Store.YES);
            doc.AddTextField("Url", entity.Url.ToString(), Field.Store.YES);
            doc.AddTextField("ImageUrl", entity.ImageUrl.ToString(), Field.Store.YES);
            doc.AddTextField("Num", entity.Num.ToString(), Field.Store.YES);
            return doc;
        }


        private Commodity GetEntityByDoc(Document doc)
        {
            var entity = new Commodity()
            {
                Id = int.Parse(doc.Get("Id")),
                ProductId = int.Parse(doc.Get("ProductId")),
                CategoryId = int.Parse(doc.Get("CategoryId")),
                Title = doc.Get("Title"),
                Price = Decimal.Parse(doc.Get("Price")),
                Url = doc.Get("Url"),
                ImageUrl = doc.Get("ImageUrl"),
                Num = doc.Get("Num")
            };
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="suffix">后缀名</param>
        /// <returns></returns>
        private IndexWriter GetCommodityIndexWriter(string suffix)
        {
            var Lucenversion = LuceneVersion.LUCENE_48;

            var IndexPath = AppContext.BaseDirectory +
                            ConfigHelper.GetInstance(StaticConst.AppSettings).GetValue(StaticConst.IndexPath) + "/" +
                            ConfigHelper.GetInstance(StaticConst.AppSettings)
                                .GetValue(StaticConst.CommodityIndexPath);
            DirectoryInfo dire = new DirectoryInfo(IndexPath);
            if (!dire.Exists)
            {
                Directory.CreateDirectory(IndexPath);
            }

            FSDirectory fsdir = FSDirectory.Open(dire);
            if (IndexWriter.IsLocked(fsdir))
            {
                IndexWriter.Unlock(fsdir);
            }

            IndexWriter writer = new IndexWriter(fsdir, new IndexWriterConfig(Lucenversion, new StandardAnalyzer(Lucenversion)));
            
            return writer;
        }

        #endregion
    }
}