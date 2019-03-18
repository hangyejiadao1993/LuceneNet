namespace NCL.LuceneService.Dto
{
    public class Commodity
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ProductId
        /// </summary>
        public long? ProductId { get; set; }

        /// <summary>
        /// 菜单类别
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 表序号
        /// </summary>
        public string Num { get; set; }
    }
}