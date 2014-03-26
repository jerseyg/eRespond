//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Project2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class User
    {
        public User()
        {
            this.Events = new HashSet<Event>();
            this.TokenAssociates = new HashSet<TokenAssociate>();
        }
    
        public System.Guid UserId { get; set; }
        [UIHint("EmailAddress")]
        public string EmailAddress { get; set; }
        public byte[] EmailAddressHash { get; set; }
        [UIHint("Password")]
        public string Password { get; set; }
        [UIHint("RetypePassword")]
        public string RetypePassword { get; set; }
        public string Salt { get; set; }
        [UIHint("FirstName")]
        public string FirstName { get; set; }
        [UIHint("LastName")]
        public string LastName { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
    
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<TokenAssociate> TokenAssociates { get; set; }
    }
}
