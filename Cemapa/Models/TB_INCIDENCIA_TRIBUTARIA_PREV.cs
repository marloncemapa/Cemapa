//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cemapa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_INCIDENCIA_TRIBUTARIA_PREV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_INCIDENCIA_TRIBUTARIA_PREV()
        {
            this.TB_FILIAL = new HashSet<TB_FILIAL>();
        }
    
        public bool COD_INC_TRIB { get; set; }
        public string DESC_INC_TRIB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_FILIAL> TB_FILIAL { get; set; }
    }
}
