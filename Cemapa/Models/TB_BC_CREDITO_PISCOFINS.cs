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
    
    public partial class TB_BC_CREDITO_PISCOFINS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_BC_CREDITO_PISCOFINS()
        {
            this.TB_OPERACAO = new HashSet<TB_OPERACAO>();
        }
    
        public string COD_BC_CREDITO_PISCOFINS { get; set; }
        public string DESC_BC_CREDITO_PISCOFINS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_OPERACAO> TB_OPERACAO { get; set; }
    }
}