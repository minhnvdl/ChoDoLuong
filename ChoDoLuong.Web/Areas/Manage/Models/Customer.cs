//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChoDoLuong.Web.Areas.Manage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> Role { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
