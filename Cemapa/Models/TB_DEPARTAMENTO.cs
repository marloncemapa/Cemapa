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
    
    public partial class TB_DEPARTAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_DEPARTAMENTO()
        {
            this.TB_HISTORICO = new HashSet<TB_HISTORICO>();
            this.TB_PEDIDO_CAB = new HashSet<TB_PEDIDO_CAB>();
        }
    
        public int COD_DEPARTAMENTO { get; set; }
        public string DESC_DEPARTAMENTO { get; set; }
        public string IND_FLUXO_CAIXA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_HISTORICO> TB_HISTORICO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PEDIDO_CAB> TB_PEDIDO_CAB { get; set; }
    }
}