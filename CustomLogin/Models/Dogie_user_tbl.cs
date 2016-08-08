//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomLogin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Dogie_user_tbl
    {
        [Required]
        [Display(Name = "User Name")]
        public string username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string email { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public System.DateTime createdBy { get; set; }

        [ScaffoldColumn(false)]
        public bool isActive { get; set; }

        [ScaffoldColumn(false)]
        public int roleId { get; set; }

        //public IEnumerable<SelectListItem> roleIds { get; set; }

        public virtual dogie_Role_tbl dogie_Role_tbl { get; set; }

        //public Dogie_user_login dogie_login { get; set; }
    }

    public partial class user_role_list
    {
        public IEnumerable<SelectListItem> roleIds { get; set; }
    }

    //This partial class is a viewmodel not bind to any table of a database
    //The viewmodel is use to add validation
    public partial class Dogie_user_login
    {
        [Required]
        [Display(Name = "User Name")]
        public string username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }
    }

    public partial class UserClassModel
    {
        public Dogie_user_tbl dogie_user { get; set; }
        public user_role_list dogie_user_list { get; set; }
        public Dogie_user_login dogie_login { get; set; }
    }
}
