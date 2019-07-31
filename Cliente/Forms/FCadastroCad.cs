﻿using Cliente.Forms.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Newtonsoft.Json;
using Cliente.POCO;
using System.Reflection;

namespace Cliente.Forms
{
    public partial class FCadastroCad : FModeloCad
    {
        #region Properties
        
        public List<TB_ESTADO> EstadoPropriedade { get; set; }
        public List<TB_CIDADE> CidadePropriedade { get; set; }
        public object Propriedade { get; set; }
        public BindingSource TipoCadastroBindingSource { get; set; }
        public BindingSource ClassCadastroBindingSource { get; set; }
        public BindingSource VendedorBindingSource { get; set; }
        public BindingSource EstadoBindingSource { get; set; }        
        public BindingSource PaisBindingSource { get; set; }
        public BindingSource CidadePropriedadeBindingSource { get; set; }
        public BindingSource PropriedadeBindingSource { get; set; }
        public BindingSource CadastroBindingSource { get; set; }
        public BindingSource EnderecoBindingSource { get; set; }
        public BindingSource QualificacaoSocioBindingSource { get; set; }
        public BindingSource FilialBindingSource { get; set; }        

        #endregion

        #region Acesso assíncrono ao servidor

        private async void BuscaDados()
        {
            // Busca o cadastro no servidor
            if (CadastroBindingSource == null)
                CadastroBindingSource = new BindingSource();

            if ("VISUALIZAR ALTERAR".Contains(this.LayoutTela))
            {
                var cadastro = JsonConvert.DeserializeAnonymousType((await RunAsyncGet(
                    ConfigurationManager.AppSettings["UriCadastro"], string.Format("{0}/{1}", "Get", this.ChaveConsulta["Codigo"])
                    )), new TB_CADASTRO());
                CadastroBindingSource.DataSource = cadastro;
            }
            else
            if ("INSERIR".Contains(this.LayoutTela))
            {
                var cadastro = new TB_CADASTRO();
                CadastroBindingSource.DataSource = cadastro;
                CadastroBindingSource.AddNew();
                (CadastroBindingSource.Current as TB_CADASTRO).COD_CADASTRO = -1;
            }   

            // DataBindings
            tbsCodigo.DataBindings.Add("Text", CadastroBindingSource.Current, "COD_CADASTRO");
            tbsNome.DataBindings.Add("Text", CadastroBindingSource.Current, "NOME");
            tbsNomeFantasia.DataBindings.Add("Text", CadastroBindingSource.Current, "DESC_FANTASIA");
            tbsTelefone.DataBindings.Add("Text", CadastroBindingSource.Current, "DESC_TELEFONE");
            tbsCelular.DataBindings.Add("Text", CadastroBindingSource.Current, "DESC_CELULAR");
            tbsEmailXML.DataBindings.Add("Text", CadastroBindingSource.Current, "DESC_E_MAIL");
            tbsEmailContato.DataBindings.Add("Text", CadastroBindingSource.Current, "DESC_E_MAIL1");
            tbsEmpresa.DataBindings.Add("Text", CadastroBindingSource.Current, "DESC_EMPRESA");
            tbsFuncao.DataBindings.Add("Text", CadastroBindingSource.Current, "DESC_FUNCAO");
            tbsTelComercial.DataBindings.Add("Text", CadastroBindingSource.Current, "DESC_TELEFONE_COMERCIAL");
            tbsCrc.DataBindings.Add("Text", CadastroBindingSource.Current, "DESC_CRC");
            tbsSequencial.DataBindings.Add("Text", CadastroBindingSource.Current, "NUM_SEQ_CRC");
            tbsValidadeCrc.DataBindings.Add("Text", CadastroBindingSource.Current, "DT_CRC");
            tbsDtFimSociedade.DataBindings.Add("Text", CadastroBindingSource.Current, "DT_CANCELAMENTO");
            tbsPercParticCapitalTotal.DataBindings.Add("Text", CadastroBindingSource.Current, "PERC_CAP_TOT");
            tbsPercParticCapitalVolante.DataBindings.Add("Text", CadastroBindingSource.Current, "PERC_CAP_VOT");
            tbsDtSeprocado.DataBindings.Add("Text", CadastroBindingSource.Current, "DT_SEPROCADO");
            

            //cbsTipoCadastro
            if (TipoCadastroBindingSource == null)
                TipoCadastroBindingSource = new BindingSource();
            TipoCadastroBindingSource.DataSource = JsonConvert.DeserializeAnonymousType((await RunAsyncGet(
                ConfigurationManager.AppSettings["UriTipoCadastro"]
                )), new List<TB_TIPO_CADASTRO>());
            if ((CadastroBindingSource.Current as TB_CADASTRO).COD_TIPO_CADASTRO > 0)
            {
                var obj = TipoCadastroBindingSource.List.OfType<TB_TIPO_CADASTRO>().First(c => c.COD_TIPO_CADASTRO == ((TB_CADASTRO)CadastroBindingSource.Current).COD_TIPO_CADASTRO);
                var pos = TipoCadastroBindingSource.IndexOf(obj);
                TipoCadastroBindingSource.Position = pos;
                obj = null;
                pos = 0;
            }
            cbsTipoCadastro.BindingSource = TipoCadastroBindingSource;
            cbsTipoCadastro.DisplayMember = "DESC_TIPO_CADASTRO";
            

            //cbsFisicaJuridica
            List<POCO.FisicaJuridica> ListaFisicaJuridica = new List<POCO.FisicaJuridica>();
            var f = new POCO.FisicaJuridica();
            f.IND_FISICA_JURIDICA = "F";
            f.DESC_FISICA_JURIDICA = "FISICA";
            var j = new POCO.FisicaJuridica();
            j.IND_FISICA_JURIDICA = "J";
            j.DESC_FISICA_JURIDICA = "JURIDICA";
            ListaFisicaJuridica.Add(f);
            ListaFisicaJuridica.Add(j);
            BindingSource fisicaJuridicaBindingSource = new BindingSource();
            fisicaJuridicaBindingSource.DataSource = ListaFisicaJuridica;
            cbsFisicaJuridica.BindingSource = fisicaJuridicaBindingSource;
            cbsFisicaJuridica.DisplayMember = "DESC_FISICA_JURIDICA";
            if ((CadastroBindingSource.Current as TB_CADASTRO).IND_FISICA_JURIDICA != null)
            {
                var objFJ = fisicaJuridicaBindingSource.List.OfType<POCO.FisicaJuridica>().First(p => p.IND_FISICA_JURIDICA == ((TB_CADASTRO)CadastroBindingSource.Current).IND_FISICA_JURIDICA);
                var pos = fisicaJuridicaBindingSource.IndexOf(objFJ);
                fisicaJuridicaBindingSource.Position = pos;
                objFJ = null;
                pos = 0;
            }

            //cbsRegimeTributário
            List<POCO.RegimeTributario> ListaRegimeTributario = new List<RegimeTributario>();
            var nRegime = new RegimeTributario();
            nRegime.IND_REGIME_TRIBUTARIO = null;
            nRegime.DESC_REGIME_TRIBUTARIO = string.Empty;
            var simples = new RegimeTributario();
            simples.IND_REGIME_TRIBUTARIO = 1;
            simples.DESC_REGIME_TRIBUTARIO = "SIMPLES NACIONAL";
            var simplesExcesso = new RegimeTributario();
            simplesExcesso.IND_REGIME_TRIBUTARIO = 2;
            simplesExcesso.DESC_REGIME_TRIBUTARIO = "SIMPLES NACIONAL - EXCESSO";
            var normal = new RegimeTributario();
            normal.IND_REGIME_TRIBUTARIO = 3;
            normal.DESC_REGIME_TRIBUTARIO = "NORMAL";
            ListaRegimeTributario.Add(simples);
            ListaRegimeTributario.Add(simplesExcesso);
            ListaRegimeTributario.Add(normal);
            BindingSource RegimeTributarioBindingSource = new BindingSource();
            RegimeTributarioBindingSource.DataSource = ListaRegimeTributario;
            cbsRegimeTributario.BindingSource = RegimeTributarioBindingSource;
            cbsRegimeTributario.DisplayMember = "DESC_REGIME_TRIBUTARIO";
            if((CadastroBindingSource.Current as TB_CADASTRO).IND_REGIME_TRIBUTARIO != null)
            {
                var objRegime = RegimeTributarioBindingSource.List.OfType<POCO.RegimeTributario>().First(p => p.IND_REGIME_TRIBUTARIO == ((TB_CADASTRO)CadastroBindingSource.Current).IND_REGIME_TRIBUTARIO);
                var pos = RegimeTributarioBindingSource.IndexOf(objRegime);
                fisicaJuridicaBindingSource.Position = pos;
                objRegime = null;
                pos = 0;
            }


            //cbsClassCadastro            
            if (ClassCadastroBindingSource == null)
                ClassCadastroBindingSource = new BindingSource();
            ClassCadastroBindingSource.DataSource = JsonConvert.DeserializeAnonymousType((await RunAsyncGet(
                ConfigurationManager.AppSettings["UriClassCadastro"]
                )), new List<TB_CLASS_CADASTRO>());
            cbsClassificacao.BindingSource = ClassCadastroBindingSource;
            cbsClassificacao.DisplayMember = "DESC_CLASSIFICACAO";            
            if ((CadastroBindingSource.Current as TB_CADASTRO).COD_CLASS_CADASTRO != null)
            {
                var objCC = ClassCadastroBindingSource.List.OfType<TB_CLASS_CADASTRO>().First(c => c.COD_CLASS_CADASTRO == ((TB_CADASTRO)CadastroBindingSource.Current).COD_CLASS_CADASTRO);
                var pos = ClassCadastroBindingSource.IndexOf(objCC);
                ClassCadastroBindingSource.Position = pos;
                objCC = null;
                pos = 0;
            }
            else
                cbsClassificacao.SelectedIndex = -1;

            //cbsVendedor  

            if (VendedorBindingSource == null)
                VendedorBindingSource = new BindingSource();
            VendedorBindingSource.DataSource = JsonConvert.DeserializeAnonymousType((await RunAsyncGet(
            ConfigurationManager.AppSettings["UriVendedor"]
            )), new List<TB_VENDEDOR>());
            cbsVendedor.BindingSource = VendedorBindingSource;
            cbsVendedor.DisplayMember = "NOME";            
            if ((CadastroBindingSource.Current as TB_CADASTRO).COD_VENDEDOR != null)
            {
                var objV = VendedorBindingSource.List.OfType<TB_VENDEDOR>().First(c => c.COD_VENDEDOR == ((TB_CADASTRO)CadastroBindingSource.Current).COD_VENDEDOR);
                var pos = VendedorBindingSource.IndexOf(objV);
                VendedorBindingSource.Position = pos;
                objV = null;
                pos = 0;
            }
            else
                cbsVendedor.SelectedIndex = -1;

            //cbsQualificacaoSocio
            if (QualificacaoSocioBindingSource == null)
                QualificacaoSocioBindingSource = new BindingSource();
            QualificacaoSocioBindingSource.DataSource
                = JsonConvert.DeserializeAnonymousType((await RunAsyncGet(
                ConfigurationManager.AppSettings["UriQualificacaoSocio"]
                )), new List<TB_QUALIFICACAO_SOCIO>());
            cbsQualificacaoSocio.BindingSource = QualificacaoSocioBindingSource;
            cbsQualificacaoSocio.DisplayMember = "DESC_QUALIFICACAO_SOCIO";
            cbsQualificacaoSocio.SelectedIndex = -1;
            if ((CadastroBindingSource.Current as TB_CADASTRO).COD_QUALIFICACAO_SOCIO != null)
            {
                var objQualif
                    = QualificacaoSocioBindingSource.List.OfType<TB_QUALIFICACAO_SOCIO>().First(q => q.COD_QUALIFICACAO_SOCIO == (CadastroBindingSource.Current as TB_CADASTRO).COD_QUALIFICACAO_SOCIO);
                var pos = QualificacaoSocioBindingSource.IndexOf(objQualif);
                QualificacaoSocioBindingSource.Position = pos;
                objQualif = null;
                pos = 0;
            }

            //cbsFilial
            if (FilialBindingSource == null)
                FilialBindingSource = new BindingSource();
            FilialBindingSource.DataSource
                = JsonConvert.DeserializeAnonymousType((await RunAsyncGet(
                string.Format("{0}/{1}", ConfigurationManager.AppSettings["UriFilial"], "Get")
                )), new List<TB_FILIAL>());
            cbsFilial.BindingSource = FilialBindingSource;
            cbsFilial.DisplayMember = "DESC_FILIAL";
            cbsFilial.SelectedIndex = -1;
            if ((CadastroBindingSource.Current as TB_CADASTRO).COD_FILIAL != null)
            {
                var objQualif
                    = FilialBindingSource.List.OfType<TB_FILIAL>().First(q => q.COD_FILIAL == (CadastroBindingSource.Current as TB_CADASTRO).COD_FILIAL);
                var pos = FilialBindingSource.IndexOf(objQualif);
                FilialBindingSource.Position = pos;
                objQualif = null;
                pos = 0;
            }

            //dgvPropriedades
            if (PropriedadeBindingSource == null)
                PropriedadeBindingSource = new BindingSource();            
            dgvPropriedades.DataSource = PropriedadeBindingSource;            
            PropriedadeBindingSource.DataSource = JsonConvert.DeserializeAnonymousType((await RunAsyncGet(
                ConfigurationManager.AppSettings["UriPropriedade"], string.Format("{0}/{1}", "Get", ((TB_CADASTRO)CadastroBindingSource.Current).COD_CADASTRO)
                )), new List<TB_PROPRIEDADE>());
            DataGridViewTextBoxColumn dgvcCidade = new DataGridViewTextBoxColumn();
            dgvcCidade.DataPropertyName = "CIDADE";
            dgvcCidade.HeaderText = "CIDADE";            
            dgvPropriedades.Columns.Add(dgvcCidade);
            dgvPropriedades.Columns["TB_CIDADE"].Visible = false;

            foreach (var col in dgvPropriedades.Columns)
            {
                var colunas = "DESC_PROPRIEDADE DESC_LOCALIDADE NUM_AREA CIDADE DESC_CRI VAL_PROPRIEDADE NUM_MATRICULA";
                if (colunas.Contains(((DataGridViewColumn)col).Name))
                {
                    ((DataGridViewColumn)col).Visible = true;
                    if ((col as DataGridViewColumn).Name.Equals("DESC_PROPRIEDADE"))
                    {
                        (col as DataGridViewColumn).HeaderText = "PROPRIEDADE";
                        (col as DataGridViewColumn).DisplayIndex = 0;
                        (col as DataGridViewColumn).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    if ((col as DataGridViewColumn).Name.Equals("DESC_LOCALIDADE"))
                    {
                        (col as DataGridViewColumn).HeaderText = "ENDEREÇO";
                        (col as DataGridViewColumn).DisplayIndex = 1;
                    }
                    if ((col as DataGridViewColumn).Name.Equals("VAL_PROPRIEDADE"))
                    {
                        (col as DataGridViewColumn).HeaderText = "VALOR";
                        (col as DataGridViewColumn).DisplayIndex = 2;
                    }
                    if ((col as DataGridViewColumn).Name.Equals("NUM_AREA"))                    
                        (col as DataGridViewColumn).HeaderText = "AREA";
                    if ((col as DataGridViewColumn).Name.Equals("DESC_CRI"))
                        (col as DataGridViewColumn).HeaderText = "CRI";
                    if ((col as DataGridViewColumn).Name.Equals("NUM_MATRICULA"))
                        (col as DataGridViewColumn).HeaderText = "MATRICULA";
                }
                else
                    ((DataGridViewColumn)col).Visible = false;
            }

            //dgvEndereco
            if (EnderecoBindingSource == null)
                EnderecoBindingSource = new BindingSource();
            dgvEndereco.DataSource = EnderecoBindingSource;
            var endereco = JsonConvert.DeserializeAnonymousType((await RunAsyncGet(
                ConfigurationManager.AppSettings["UriEndereco"], string.Format("{0}/{1}", "Get", ((TB_CADASTRO)CadastroBindingSource.Current).COD_CADASTRO)
                )), new List<TB_CADASTRO_ENDERECOS>());
            EnderecoBindingSource.DataSource = endereco;
            var colEndereco = new string[] { "DESC_ENDERECO", "DESC_CIDADE", "COD_ESTADO", "DESC_CEP" };
            foreach (var col in dgvEndereco.Columns)
            {
                if (colEndereco.Contains(((DataGridViewColumn)col).Name))
                {
                    ((DataGridViewColumn)col).Visible = true;
                    if (((DataGridViewColumn)col).Name.Equals("DESC_ENDERECO"))
                    {
                        (col as DataGridViewColumn).HeaderText = "ENDEREÇO";
                        (col as DataGridViewColumn).DisplayIndex = 1;
                        (col as DataGridViewColumn).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    if ((col as DataGridViewColumn).Name.Equals("DESC_CIDADE"))
                    {
                        (col as DataGridViewColumn).HeaderText = "CIDADE";
                        (col as DataGridViewColumn).DisplayIndex = 2;
                    }
                    if ((col as DataGridViewColumn).Name.Equals("COD_ESTADO"))
                    {
                        (col as DataGridViewColumn).HeaderText = "ESTADO";
                        (col as DataGridViewColumn).DisplayIndex = 3;
                    }
                    if ((col as DataGridViewColumn).Name.Equals("DESC_CEP"))
                    {
                        (col as DataGridViewColumn).HeaderText = "CEP";
                        (col as DataGridViewColumn).DisplayIndex = 4;
                    }
                }
                else
                {
                    (col as DataGridViewColumn).Visible = false;
                }

            }

        }

        #endregion

        public FCadastroCad(string layout) : base(layout)
        {
            InitializeComponent();
            this.Personaliza();
            this.lbNome.Text = "FORMULÁRIO DE CADASTRO";
        }

        private async void btSalvar_Click(object sender, EventArgs e)
        {
            (CadastroBindingSource.Current as TB_CADASTRO).TB_CADASTRO_ENDERECOS
                .Add(EnderecoBindingSource.Current as TB_CADASTRO_ENDERECOS);
            (CadastroBindingSource.Current as TB_CADASTRO).TB_PROPRIEDADE
                .Add(PropriedadeBindingSource.Current as TB_PROPRIEDADE);
            (CadastroBindingSource.Current as TB_CADASTRO).COD_TIPO_CADASTRO
                = (TipoCadastroBindingSource.Current as TB_TIPO_CADASTRO).COD_TIPO_CADASTRO;
            (CadastroBindingSource.Current as TB_CADASTRO).COD_FILIAL
                = (FilialBindingSource.Current as TB_FILIAL).COD_FILIAL;
            CadastroBindingSource.EndEdit();
            MessageBox.Show(
            await RunAsyncPost(
                string.Format("{0}/{1}", ConfigurationManager.AppSettings["UriCadastro"], "Save"), CadastroBindingSource.Current)
                
                );
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {   
            CadastroBindingSource.CancelEdit();
        }       

        private void cbsFisicaJuridica_SelectedValueChanged(object sender, EventArgs e)
        {            
        }

        private void cbsFisicaJuridica_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                MessageBox.Show(cbsFisicaJuridica.SelectedValue + " " + cbsFisicaJuridica.SelectedText);
            }
        }

        private void cbsFisicaJuridica_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show(cbsFisicaJuridica.SelectedValue + " " + cbsFisicaJuridica.SelectedText);
        }

        private void cbsFisicaJuridica_ComboBoxDropDownClosed(object sender, EventArgs e)
        {
            MessageBox.Show(cbsFisicaJuridica.SelectedValue + " " + cbsFisicaJuridica.SelectedText);
        }

        private void FCadastroCad_Load(object sender, EventArgs e)
        {  
            BuscaDados();
        }

        private void btAlterarProriedade_Click(object sender, EventArgs e)
        {
            if (PropriedadeBindingSource.Current == null)
                return;

            FPropriedadeCad f = new FPropriedadeCad("ALTERAR");                       
            f.PropriedadeBindingSource = PropriedadeBindingSource;            
            f.Show();            
        }

        private void btNovaPropriedade_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((TB_PROPRIEDADE)PropriedadeBindingSource.Current).IND_TIPO_IMOVEL);
        }

        private void dgvPropriedades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPropriedades.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (dgvPropriedades.Columns[e.ColumnIndex].DataPropertyName.Equals("CIDADE"))
                    if ((dgvPropriedades.Rows[e.RowIndex].DataBoundItem as TB_PROPRIEDADE).TB_CIDADE != null)
                        e.Value = (((dgvPropriedades.Rows[e.RowIndex].DataBoundItem as TB_PROPRIEDADE).TB_CIDADE).DESC_CIDADE);
            }
        }

        private void btAlterarEndereco_Click(object sender, EventArgs e)
        {
            if (EnderecoBindingSource.Current == null)
                return;

            FEnderecoCad f = new FEnderecoCad("ALTERAR");
            f.EnderecoBindingSource = EnderecoBindingSource;
            f.Show();
        }        
    }

}