using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoDesktop
{
    public partial class InserirCliente : Form
    {
        public InserirCliente()
        {
            InitializeComponent();
        }

        private void InserirCliente_Load(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.nome = txtNome.Text;
            cli.idade = int.Parse(nuIdade.Value.ToString());
            cli.telefone = mskTelefone.Text;
            cli.endereco = txtEndereco.Text;
            cli.sexo = (rbMasculino.Checked ? 'M' : 'F');
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            nuIdade.Value = 0;
            mskTelefone.Text = "";
            txtEndereco.Text = "";
            rbMasculino.Checked = false;
            rbFeminino.Checked = false;
        }
    }
}
