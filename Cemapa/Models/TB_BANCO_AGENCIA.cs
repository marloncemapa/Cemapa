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
    
    public partial class TB_BANCO_AGENCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_BANCO_AGENCIA()
        {
            this.TB_PEDIDO_CAB = new HashSet<TB_PEDIDO_CAB>();
        }
    
        public int COD_BANCO_AGENCIA { get; set; }
        public string COD_ESTADO { get; set; }
        public string DESC_BANCO_AGENCIA { get; set; }
        public string DESC_CIDADE { get; set; }
        public string DESC_SIGLA { get; set; }
        public string DESC_LOCAL_PGTO_BLOQ { get; set; }
        public string DESC_INSTRUCAO_BLOQUETO { get; set; }
        public string IND_TIPO_JURO { get; set; }
        public Nullable<decimal> PERC_JURO_BLOQUETO { get; set; }
        public Nullable<byte> NUM_LIN_VALOR { get; set; }
        public Nullable<byte> NUM_COL_VALOR { get; set; }
        public Nullable<byte> NUM_LIN_VAL_EXTENSO { get; set; }
        public Nullable<byte> NUM_COL_VAL_EXTENSO { get; set; }
        public Nullable<byte> NUM_TAM_VAL_EXTENSO { get; set; }
        public Nullable<byte> NUM_LIN_NOMINAL { get; set; }
        public Nullable<byte> NUM_COL_NOMINAL { get; set; }
        public Nullable<byte> NUM_TAM_NOMINAL { get; set; }
        public Nullable<byte> NUM_LIN_CIDADE { get; set; }
        public Nullable<byte> NUM_COL_CIDADE { get; set; }
        public Nullable<byte> NUM_TAM_CIDADE { get; set; }
        public Nullable<byte> NUM_LIN_DIA { get; set; }
        public Nullable<byte> NUM_COL_DIA { get; set; }
        public Nullable<byte> NUM_LIN_FINAL { get; set; }
        public Nullable<byte> NUM_COL_MES { get; set; }
        public Nullable<byte> NUM_COL_ANO { get; set; }
        public string DESC_ANO_FORMATO { get; set; }
        public Nullable<byte> COD_BANCO { get; set; }
        public Nullable<short> COD_AGENCIA { get; set; }
        public string COD_CONTABIL_VL_DESC_BCO_CRED { get; set; }
        public string COD_CONTABIL_VL_JURO_BCO_DEB { get; set; }
        public string COD_CONTABIL_VL_PRIN_BCO_DEB { get; set; }
        public string COD_CONTABIL_VALOR_FILIAL { get; set; }
        public Nullable<long> NUM_INSCR_CEDENTE { get; set; }
        public Nullable<short> PREFIXO_AGENCIA { get; set; }
        public string DIGITO_VERIFICADOR_AGENCIA { get; set; }
        public Nullable<int> CODIGO_CEDENTE { get; set; }
        public string DIGITO_VERIFICADOR_CEDENTE { get; set; }
        public Nullable<int> NUM_CONVENIO { get; set; }
        public Nullable<long> NOSSO_NUMERO { get; set; }
        public string DIGITO_VERIFICADOR_N_NR { get; set; }
        public string COD_CONTABIL_VL_PRIN_BCO_CRED { get; set; }
        public string COD_CONTABIL_VL_JURO_BCO_CRED { get; set; }
        public string COD_CONTABIL_VL_DESC_BCO_DEB { get; set; }
        public Nullable<int> COD_CONVENENTE_LIDER { get; set; }
        public string COD_CONTABIL_CONTRAPARTIDA { get; set; }
        public Nullable<long> COD_CONVENIO_CUSTODIA { get; set; }
        public Nullable<long> COD_CONVENIO_DESCONTO { get; set; }
        public Nullable<decimal> PERC_TAXA_LIMITE { get; set; }
        public Nullable<decimal> VAL_LIMITE_CHEQUE { get; set; }
        public string COD_CONTABIL_VL_TAXA_CRED { get; set; }
        public string COD_CONTABIL_VL_TAXA_DEB { get; set; }
        public Nullable<int> COD_HISTORICO_CAIXA_TAXA { get; set; }
        public Nullable<decimal> NUM_COD_EMPRESA { get; set; }
        public Nullable<int> COD_COBRANCA { get; set; }
    
        public virtual TB_ESTADO TB_ESTADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PEDIDO_CAB> TB_PEDIDO_CAB { get; set; }
    }
}