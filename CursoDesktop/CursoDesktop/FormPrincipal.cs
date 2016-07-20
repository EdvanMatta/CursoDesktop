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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastarCliente formCadastrarCliente = new CadastarCliente();
            formCadastrarCliente.MdiParent = this.MdiParent;
            formCadastrarCliente.Show();
        }
    }
}
