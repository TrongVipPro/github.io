//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanHangOnline.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_ProductCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_ProductCategory()
        {
            this.tb_Product = new HashSet<tb_Product>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Modifiedby { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Product> tb_Product { get; set; }
    }
}
