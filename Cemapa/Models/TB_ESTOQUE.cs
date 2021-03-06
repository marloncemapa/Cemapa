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
    
    public partial class TB_ESTOQUE
    {
        public int COD_LOTE_TIPO { get; set; }
        public int COD_FILIAL { get; set; }
        public long COD_PRODUTO { get; set; }
        public Nullable<decimal> VL_CUSTO_MEDIO { get; set; }
        public Nullable<decimal> VL_ULTIMO_CUSTO { get; set; }
        public Nullable<decimal> VL_CUSTO_DOLAR { get; set; }
        public decimal QT_QUANTIDADE { get; set; }
        public Nullable<System.DateTime> DT_COMPRA { get; set; }
        public Nullable<System.DateTime> DT_VENDA { get; set; }
        public Nullable<decimal> QT_COMPRA { get; set; }
        public Nullable<decimal> QT_MINIMO { get; set; }
        public Nullable<decimal> QT_MAXIMO { get; set; }
        public Nullable<decimal> QT_INVENTARIO { get; set; }
        public Nullable<System.DateTime> DT_INVENTARIO { get; set; }
        public Nullable<decimal> VL_CUSTO_INVENTARIO { get; set; }
        public Nullable<int> QT_COMPROMETIDO { get; set; }
        public Nullable<decimal> VL_ULTIMA_VENDA { get; set; }
        public Nullable<int> COD_ULTIMO_FORNECEDOR { get; set; }
        public string DESC_LOCALIZACAO { get; set; }
        public string DESC_HASH_MD5 { get; set; }
        public Nullable<decimal> VL_CUSTO_COMISSAO { get; set; }
    
        public virtual TB_PRODUTO TB_PRODUTO { get; set; }
    }
}
