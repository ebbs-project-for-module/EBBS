//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBBS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Board
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Board()
        {
            this.Post = new HashSet<Post>();
        }
    
        public int bId { get; set; }
        public int categoryId { get; set; }
        public string boardTitle { get; set; }
        public string description { get; set; }
        public int creatorId { get; set; }
        public System.DateTime dateCreated { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Post { get; set; }
    }
}
