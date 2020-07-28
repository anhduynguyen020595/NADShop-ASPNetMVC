﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NADShop.Web.Models
{
    public class PostCategoryViewModel : AuditableViewModel
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }
        public virtual IEnumerable<PostViewModel> Posts { set; get; }
    }
}