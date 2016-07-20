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
    public partial class CadastarProduto : Form
    {
        public CadastarProduto()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            InserirProduto formInserirProduto = new InserirProduto();
            formInserirProduto.MdiParent = this.MdiParent;
            formInserirProduto.Show();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutennnção!");
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutennnção!");
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
        }
    }
}
