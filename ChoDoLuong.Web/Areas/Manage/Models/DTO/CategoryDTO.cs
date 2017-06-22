using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoDoLuong.Admin.Models.DTO
{
    public class CategoryDTO
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryID { get; set; }
        public string Picture { get; set; }
        public bool? ShowOnHome { get; set; }
        public int? DisplayOrder { get; set; }
        public System.DateTime? CreatedOnUtc { get; set; }
        public System.DateTime? UpdateOnUtc { get; set; }
    }
}