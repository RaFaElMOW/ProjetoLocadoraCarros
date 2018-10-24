using projetoLocadoraCarro.controlador;
using projetoLocadoraCarro.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLocadoraCarro
{
    public partial class TelaCadastroVeiculoProprietario : Form
    {
        ControladorTelaCadastroProprietario controladorProprietario = new ControladorTelaCadastroProprietario();
        public TelaCadastroVeiculoProprietario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Proprietario proprietario = new Proprietario();

            proprietario.NomeProp = txtNomeProprietario.Text;
            proprietario.EnderecoProp = txtEnderecoProprietario.Text;
            proprietario.BairroProp = txtBairroProprietario.Text;
            proprietario.ComplementoProp = txtComplementoProprietario.Text;
            proprietario.CidadeProp = txtCidadeProprietario.Text;
            proprietario.EstadoProp = cmbEstadoProprietario.Text;
            proprietario.RgProp = txtRgProprietario.Text;
            proprietario.CpfProp = int.Parse(txtCpfProprietario.Text);
            proprietario.DataNascimentoProp = dtpDataNascProprietario.Text;
            //proprietario.PrimeiroVeiculoProp = bool.Parse(cbxNumVeiculo.Text);
            if(rbtSexoMascProprietario.Checked == true)
            {
                proprietario.SexoProp = rbtSexoMascProprietario.Text;
            }
            else
            {
                proprietario.SexoProp = rbtSexoFemProprietario.Text;
            }
            controladorProprietario.InserirProprietario(proprietario);

        }
    }
}
