//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baran.Ferroalloy.Automation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tabTechnicalDocuments
    {
        public int intID { get; set; }
        public Nullable<bool> bitSelect { get; set; }
        public string nvcTitle { get; set; }
        public Nullable<int> intCompany { get; set; }
        public Nullable<int> intLocation { get; set; }
        public Nullable<int> intCategory { get; set; }
        public Nullable<int> intOrder { get; set; }
        public Nullable<int> intType { get; set; }
        public string nvcCoDesigner { get; set; }
        public string nvcPersonDesigner { get; set; }
        public string nvcRevisionNumber { get; set; }
    
        public virtual tabCategories tabCategories { get; set; }
        public virtual tabCompanies tabCompanies { get; set; }
        public virtual tabLocationes tabLocationes { get; set; }
        public virtual tabTechnicalDocumentTypes tabTechnicalDocumentTypes { get; set; }
    }
}
