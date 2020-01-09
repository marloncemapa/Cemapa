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
    
    public partial class TB_PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_PRODUTO()
        {
            this.TB_LOTE_TIPO = new HashSet<TB_LOTE_TIPO>();
            this.TB_ESTOQUE = new HashSet<TB_ESTOQUE>();
            this.TB_PRODUTO_SKYHUB = new HashSet<TB_PRODUTO_SKYHUB>();
            this.TB_SINCRONIZACAO_SKYHUB = new HashSet<TB_SINCRONIZACAO_SKYHUB>();
            this.TB_TABELA_PRECO_ITEM = new HashSet<TB_TABELA_PRECO_ITEM>();
            this.TB_PEDIDO_CAB = new HashSet<TB_PEDIDO_CAB>();
            this.TB_PEDIDO_ITEM = new HashSet<TB_PEDIDO_ITEM>();
            this.TB_PEDIDO_ITEM1 = new HashSet<TB_PEDIDO_ITEM>();
        }
    
        public long COD_PRODUTO { get; set; }
        public int COD_CLASSE { get; set; }
        public int COD_TRIBUTACAO { get; set; }
        public string DESC_PRODUTO { get; set; }
        public Nullable<decimal> NUM_EMBALAGEM { get; set; }
        public string DESC_UNIDADE { get; set; }
        public Nullable<byte> NUM_TRIB_TRANSFERENCIA { get; set; }
        public Nullable<decimal> VAL_VAREJO { get; set; }
        public Nullable<decimal> VAL_ATACADO { get; set; }
        public Nullable<decimal> PERC_DESCONTO_MAXIMO { get; set; }
        public Nullable<decimal> PERC_IPI { get; set; }
        public string DESC_CLASS_FISCAL { get; set; }
        public string IND_TIPO_PRODUTO { get; set; }
        public Nullable<System.DateTime> DT_ALTERACAO_PRECO { get; set; }
        public string NUM_FABRICANTE { get; set; }
        public Nullable<int> COD_CADASTRO { get; set; }
        public Nullable<decimal> PERC_COMISSAO { get; set; }
        public decimal PERC_ISS { get; set; }
        public decimal PERC_INSS { get; set; }
        public Nullable<decimal> PRECO_PROMOCAO { get; set; }
        public Nullable<System.DateTime> DT_PRECO_PRO_INI { get; set; }
        public Nullable<System.DateTime> DT_PRECO_PRO_FIN { get; set; }
        public string IND_SITUACAO { get; set; }
        public string DESC_COMPLEMENTO_PROMOCAO { get; set; }
        public string DESC_COMPLEMENTO { get; set; }
        public Nullable<long> COD_PRODUTO_B { get; set; }
        public string IND_CLASSE_TOX { get; set; }
        public string DESC_FORMULACAO { get; set; }
        public string DESC_GRUPO_QUIMICO { get; set; }
        public Nullable<decimal> NUM_VOLUMES { get; set; }
        public string IND_CESTA_BASICA { get; set; }
        public Nullable<decimal> NUM_METROS_CUBICOS { get; set; }
        public string IND_TIPO_EMBALAGEM { get; set; }
        public string DESC_COMPLEMENTO_2 { get; set; }
        public string IND_TIPO_VASILHAME { get; set; }
        public Nullable<decimal> PRECO_PROMOCAO1 { get; set; }
        public string IND_ESTOFARIA { get; set; }
        public string IND_PINTURA { get; set; }
        public Nullable<decimal> VAL_PRECO_FRETE { get; set; }
        public string IND_RETORNAVEL { get; set; }
        public Nullable<byte> NUM_CX_PALETE { get; set; }
        public string IND_KM { get; set; }
        public Nullable<int> COD_MARCA { get; set; }
        public Nullable<System.DateTime> DT_VENCTO_PRECO { get; set; }
        public Nullable<int> COD_LOTE_TIPO { get; set; }
        public string COD_NBM_SH { get; set; }
        public string IND_SUBSTITUICAO_RJ { get; set; }
        public Nullable<decimal> PERC_MARGEM { get; set; }
        public Nullable<decimal> PERC_MARGEM_VAREJO { get; set; }
        public Nullable<decimal> PERC_MARGEM_ATACADO { get; set; }
        public Nullable<decimal> QT_TECIDO { get; set; }
        public string DESC_LOCALIZACAO { get; set; }
        public Nullable<decimal> NUM_CONVERTE_FARDO { get; set; }
        public string COD_EX_TIPI { get; set; }
        public string NUM_GENERO_NCM { get; set; }
        public Nullable<short> COD_LISTA_SERVICO { get; set; }
        public Nullable<int> COD_GENERO_PRODUTO { get; set; }
        public Nullable<decimal> QT_PESO_CAIXA_MIN { get; set; }
        public Nullable<decimal> QT_PESO_CAIXA_MAX { get; set; }
        public Nullable<byte> NUM_DIAS_VALIDADE { get; set; }
        public Nullable<int> COD_CULTURA { get; set; }
        public string IND_PESO_PADRAO { get; set; }
        public string DESC_SECAO { get; set; }
        public string DESC_BOQUETA { get; set; }
        public string DESC_OBSERVACAO { get; set; }
        public Nullable<decimal> NUM_PESO_BRUTO { get; set; }
        public Nullable<decimal> NUM_PESO_LIQUIDO { get; set; }
        public Nullable<short> COD_PRODUTO_SIAGRO { get; set; }
        public string COD_TIPO_PRODUTO { get; set; }
        public string COD_CST_IPI { get; set; }
        public Nullable<short> NUM_ORIGEM { get; set; }
        public string DESC_CONCENTRACAO { get; set; }
        public string COD_CST_COFINS { get; set; }
        public string COD_CST_PIS { get; set; }
        public Nullable<byte> COD_NATUREZA_RECEITA { get; set; }
        public string COD_SERVICO_MUNICIPAL { get; set; }
        public string DESC_COD_BARRA { get; set; }
        public Nullable<int> COD_PRODUTO_ANP { get; set; }
        public Nullable<decimal> QT_TEMP { get; set; }
        public string COD_UF_CONSUMO { get; set; }
        public string COD_CST_PIS_SAIDA { get; set; }
        public string COD_CST_COFINS_SAIDA { get; set; }
        public Nullable<int> COD_ATIVIDADE_CONTRIB { get; set; }
        public string IND_SUBST_TRIB { get; set; }
        public string IND_ARREDONDAMENTO_TRUNCAMENTO { get; set; }
        public string IND_PROD_PROPRIA_TERCEIRO { get; set; }
        public string IND_MARCENARIA { get; set; }
        public Nullable<short> IND_QTD_ETIQUETAS { get; set; }
        public string DESC_HASH_MD5 { get; set; }
        public Nullable<decimal> PERC_MARGEM_MINIMA { get; set; }
        public string IND_PRECO_VENDA_ETIQUETA { get; set; }
        public Nullable<decimal> PERC_MIXGN { get; set; }
        public string DESC_RECOPI { get; set; }
        public string COD_CST_IPI_SAIDA { get; set; }
        public string IND_APLICA_DEDUCAO_BC_ISS { get; set; }
        public string DESC_UNIDADE_DOSAGEM_RECEITA { get; set; }
        public Nullable<decimal> NUM_EMBALAGEM_RECEITA { get; set; }
        public string COD_CEST { get; set; }
        public Nullable<int> COD_ROYALTIES { get; set; }
        public string IND_SOLADO { get; set; }
        public string IND_BICO { get; set; }
        public string DESC_TIME { get; set; }
        public string DESC_ESPORTE { get; set; }
        public string IND_ENFEITE { get; set; }
        public Nullable<decimal> PERC_GLP_PETROLEO { get; set; }
        public Nullable<decimal> PERC_GNI { get; set; }
        public string IND_ESCALA_RELEVANTE { get; set; }
        public string DESC_CNPJ_FABRICANTE { get; set; }
        public string IND_NIR_SYNC_SITE { get; set; }
        public string IND_SINC_MAX_ROTEIRIZADOR { get; set; }
        public Nullable<decimal> PERC_COMISSAO_PRODUCAO { get; set; }
        public Nullable<int> COD_MATERIA_PRIMA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_LOTE_TIPO> TB_LOTE_TIPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ESTOQUE> TB_ESTOQUE { get; set; }
        public virtual TB_TRIBUTACAO TB_TRIBUTACAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO_SKYHUB> TB_PRODUTO_SKYHUB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SINCRONIZACAO_SKYHUB> TB_SINCRONIZACAO_SKYHUB { get; set; }
        public virtual TB_GENERO_PRODUTO TB_GENERO_PRODUTO { get; set; }
        public virtual TB_LISTA_SERVICO TB_LISTA_SERVICO { get; set; }
        public virtual TB_CST_COFINS TB_CST_COFINS { get; set; }
        public virtual TB_CST_PIS TB_CST_PIS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TABELA_PRECO_ITEM> TB_TABELA_PRECO_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PEDIDO_CAB> TB_PEDIDO_CAB { get; set; }
        public virtual TB_CLASSE TB_CLASSE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PEDIDO_ITEM> TB_PEDIDO_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PEDIDO_ITEM> TB_PEDIDO_ITEM1 { get; set; }
    }
}
