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
    
    public partial class tabCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tabCategories()
        {
            this.tabEquipName = new HashSet<tabEquipName>();
            this.tabMeasurementUnits = new HashSet<tabMeasurementUnits>();
            this.tabProperties = new HashSet<tabProperties>();
            this.tabPartTypes = new HashSet<tabPartTypes>();
            this.tabEquipSamples = new HashSet<tabEquipSamples>();
            this.tabPartName = new HashSet<tabPartName>();
        }
    
        public int intID { get; set; }
        public Nullable<bool> bitSelect { get; set; }
        public Nullable<bool> bitIsActual { get; set; }
        public string nvcName { get; set; }
        public int intNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabEquipName> tabEquipName { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabMeasurementUnits> tabMeasurementUnits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabProperties> tabProperties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabPartTypes> tabPartTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabEquipSamples> tabEquipSamples { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabPartName> tabPartName { get; set; }
    }
}