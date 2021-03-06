﻿using System;
using System.Collections.Generic;

namespace NCL.Entity
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public int? CategoryLevel { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? State { get; set; }
    }
}
