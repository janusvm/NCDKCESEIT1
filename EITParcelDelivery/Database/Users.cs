//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EITParcelDelivery.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> Role { get; set; }
    
        public virtual Cities Cities { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
