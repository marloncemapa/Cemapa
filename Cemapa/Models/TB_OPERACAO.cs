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
    
    public partial class TB_OPERACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_OPERACAO()
        {
            this.TB_CADASTRO = new HashSet<TB_CADASTRO>();
            this.TB_PEDIDO_CAB = new HashSet<TB_PEDIDO_CAB>();
            this.TB_CONFIGURACAO_SKYHUB = new HashSet<TB_CONFIGURACAO_SKYHUB>();
        }
    
        public int COD_OPERACAO { get; set; }
        public string DESC_OPERACAO { get; set; }
        public Nullable<short> NUM_NATUREZA_EST { get; set; }
        public Nullable<short> NUM_NATUREZA_INT { get; set; }
        public string IND_ESTOQUE { get; set; }
        public string IND_CUSTO { get; set; }
        public string IND_VENDAS { get; set; }
        public string IND_LIBERADO { get; set; }
        public string IND_FUTURA_CLIENTE { get; set; }
        public string IND_FUTURA_FORNECEDOR { get; set; }
        public string IND_CUSTO_NOTA { get; set; }
        public string IND_EMITE { get; set; }
        public string IND_TRANSFERENCIA { get; set; }
        public string IND_COMPRAS { get; set; }
        public string IND_PRECO { get; set; }
        public string IND_FIXAR_EMPRESA { get; set; }
        public string IND_FIXAR_OUTRAS_EMP { get; set; }
        public string IND_FUNRURAL { get; set; }
        public string DESC_RESUMO { get; set; }
        public Nullable<short> NUM_LIVROS { get; set; }
        public Nullable<int> COD_HISTORICO_CAIXA { get; set; }
        public string IND_DUPLICATA { get; set; }
        public string IND_BLOQUETO { get; set; }
        public string IND_PEDIDO_CLIENTE { get; set; }
        public string IND_CONSIGNACAO_FORNECEDOR { get; set; }
        public string IND_CONSIGNACAO_CLIENTE { get; set; }
        public string IND_EMPRESTIMO_FORNECEDOR { get; set; }
        public string IND_EMPRESTIMO_CLIENTE { get; set; }
        public string IND_TIPO_OPERACAO { get; set; }
        public string IND_CONTA_PAGAR { get; set; }
        public string COD_CONTABIL_VAL_NOTA_CRED { get; set; }
        public string COD_CONTABIL_VAL_NOTA_DEB { get; set; }
        public string COD_CONTABIL_VAL_ICMS_CRED { get; set; }
        public string COD_CONTABIL_VAL_ICMS_DEB { get; set; }
        public string COD_CONTABIL_VAL_FUNRURAL_CRED { get; set; }
        public string COD_CONTABIL_VAL_FUNRURAL_DEB { get; set; }
        public string COD_CONTABIL_FRETE_CRED { get; set; }
        public string COD_CONTABIL_FRETE_DEB { get; set; }
        public string COD_CONTABIL_FRETE_ICMS_CRED { get; set; }
        public string COD_CONTABIL_FRETE_ICMS_DEB { get; set; }
        public Nullable<int> COD_HISTORICO_CONTABIL { get; set; }
        public string IND_DEPOSITO_OUTRAS { get; set; }
        public string IND_DEPOSITO_EMPRESA { get; set; }
        public string IND_FIXAR_CONSUMO { get; set; }
        public string IND_LIVRO_FISCAL { get; set; }
        public string IND_CUPOM_FISCAL { get; set; }
        public string COD_SERIE { get; set; }
        public string COD_CONTABIL_VAL_NOTA_APRAZO { get; set; }
        public string COD_CONTABIL_DESC_AFIXAR_DEB { get; set; }
        public string COD_CONTABIL_DESC_AFIXAR_CRED { get; set; }
        public Nullable<int> COD_OPERACAO_ENTRADA { get; set; }
        public string COD_CONTABIL_CONTRATO_DEB { get; set; }
        public string COD_CONTABIL_CONTRATO_CRED { get; set; }
        public string IND_BONIFICACAO { get; set; }
        public string COD_CONT_VAL_NOTA_CRED_AVISTA { get; set; }
        public Nullable<int> COD_MENSAGEM { get; set; }
        public Nullable<int> COD_TRIBUTACAO { get; set; }
        public Nullable<short> NUM_NATUREZA_EST_NOVO { get; set; }
        public Nullable<short> NUM_NATUREZA_INT_NOVO { get; set; }
        public string IND_OBS_FRETE_SEGURO { get; set; }
        public string IND_BRINDE { get; set; }
        public Nullable<int> COD_RAMO { get; set; }
        public string IND_TIPO_PAGAMENTO { get; set; }
        public string COD_CONTABIL_PIS_DEB { get; set; }
        public string COD_CONTABIL_PIS_CRED { get; set; }
        public string COD_CONTABIL_COFINS_DEB { get; set; }
        public string COD_CONTABIL_COFINS_CRED { get; set; }
        public Nullable<int> COD_HISTORICO_CONTABIL_PIS { get; set; }
        public Nullable<int> COD_HISTORICO_CONTABIL_COFINS { get; set; }
        public Nullable<decimal> PERC_BASE_PIS { get; set; }
        public Nullable<decimal> PERC_BASE_COFINS { get; set; }
        public string IND_FISICA_JURIDICA { get; set; }
        public string IND_POCKET { get; set; }
        public string IND_TROCA { get; set; }
        public string COD_CONTABIL_FACS_DEB { get; set; }
        public string COD_CONTABIL_FACS_CRED { get; set; }
        public string COD_CONTABIL_FETHAB_DEB { get; set; }
        public string COD_CONTABIL_FETHAB_CRED { get; set; }
        public string COD_CONTABIL_PEDAGIO_DEB { get; set; }
        public string COD_CONTABIL_PEDAGIO_CRED { get; set; }
        public string COD_CONTABIL_SEST_DEB { get; set; }
        public string COD_CONTABIL_SEST_CRED { get; set; }
        public string IND_CONTRATO_ARROZ { get; set; }
        public string COD_CONTABIL_IRRF_CRED { get; set; }
        public string COD_CONTABIL_IRRF_DEB { get; set; }
        public string COD_CONTABIL_CSLL_DEB { get; set; }
        public string COD_CONTABIL_CSLL_CRED { get; set; }
        public string COD_CONTABIL_INSS_CRED { get; set; }
        public string COD_CONTABIL_INSS__DEB { get; set; }
        public string COD_CONTABIL_INSS_DEB { get; set; }
        public string COD_CONTABIL_ISSQN_DEB { get; set; }
        public string COD_CONTABIL_ISSQN_CRED { get; set; }
        public string COD_CONTABIL_TRANSGENICO_DEB { get; set; }
        public string COD_CONTABIL_TRANSGENICO_CRED { get; set; }
        public string COD_CONTABIL_FITAS_CRED { get; set; }
        public string COD_CONTABIL_FITAS_DEB { get; set; }
        public Nullable<int> COD_OPERACAO_ENTRADA_AGRICOLA { get; set; }
        public string COD_CONTABIL_NOTA_CRED_DUP { get; set; }
        public string COD_CONTABIL_NOTA_DEB_DUP { get; set; }
        public string COD_CONTABIL_CSSL_DBB { get; set; }
        public string IND_CONTROLE_ESTOQUE { get; set; }
        public string IND_GERA_MEMORANDO { get; set; }
        public Nullable<short> IND_FINALIDADE_NFE { get; set; }
        public string COD_CONTABIL_CONTRATO_INC_DEB { get; set; }
        public string COD_CONTABIL_CONTRATO_INC_CRED { get; set; }
        public string COD_CONT_VAR_CAMBIAL_POS_DEB { get; set; }
        public string COD_CONT_VAR_CAMBIAL_POS_CRED { get; set; }
        public string COD_CONT_VAR_CAMBIAL_NEG_DEB { get; set; }
        public string COD_CONT_VAR_CAMBIAL_NEG_CRED { get; set; }
        public string IND_NATUREZA_EXPORTACAO { get; set; }
        public string IND_TELECOMUNICACAO { get; set; }
        public string IND_SERVICO { get; set; }
        public string IND_SENAR { get; set; }
        public string IND_PROMISSORIA { get; set; }
        public string COD_CST_IPI { get; set; }
        public string IND_REMESSA_ENTRADA { get; set; }
        public string COD_CONTABIL_IPI_DEB { get; set; }
        public string COD_CONTABIL_IPI_CRED { get; set; }
        public string COD_CONTABIL_CUSTO_DEB { get; set; }
        public string COD_CONTABIL_CUSTO_CRED { get; set; }
        public string IND_CONDICIONAL { get; set; }
        public string COD_BC_CREDITO_PISCOFINS { get; set; }
        public string COD_SERIE_MODELO { get; set; }
        public string IND_EMITE_RECIBO_ENTRADA { get; set; }
        public string IND_MODAL_CTE { get; set; }
        public Nullable<short> IND_TIPO_CTE { get; set; }
        public string COD_CST_PIS { get; set; }
        public string COD_CST_COFINS { get; set; }
        public string IND_SEGUNDA_VIA_CUPOM { get; set; }
        public Nullable<short> COD_CFOP_ST { get; set; }
        public Nullable<short> COD_CFOP_INT_ST { get; set; }
        public string IND_OBRIGA_VALE_PRODUTO { get; set; }
        public Nullable<int> COD_HISTORICO_CAIXA_CREDITO { get; set; }
        public Nullable<int> COD_HISTORICO_CAIXA_DEBITO { get; set; }
        public string COD_CONTABIL_NOTA_SPED_CONTRIB { get; set; }
        public string COD_CONTABIL_SUBST_DEB { get; set; }
        public string COD_CONTABIL_SUBST_CRED { get; set; }
        public string COD_CONTABIL_FCCIA_DEB { get; set; }
        public string COD_CONTABIL_FCCIA_CRED { get; set; }
        public string COD_BENEF_FISCAL { get; set; }
    
        public virtual TB_BC_CREDITO_PISCOFINS TB_BC_CREDITO_PISCOFINS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CADASTRO> TB_CADASTRO { get; set; }
        public virtual TB_HISTORICO TB_HISTORICO { get; set; }
        public virtual TB_HISTORICO_CONTABIL TB_HISTORICO_CONTABIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PEDIDO_CAB> TB_PEDIDO_CAB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CONFIGURACAO_SKYHUB> TB_CONFIGURACAO_SKYHUB { get; set; }
    }
}
