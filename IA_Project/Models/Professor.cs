//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IA_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Professor
    {
        public int id { get; set; }
        public string User_Name { get; set; }
        public string password { get; set; }
        public byte[] image { get; set; }
        public Nullable<decimal> phone_number { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
