using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Final
{
    public partial class FrmGrid : Form
    {
        public FrmGrid()
        {
            InitializeComponent();
        }

        private void FrmGrid_Load(object sender, EventArgs e)
        {
            StreamReader csv = new StreamReader(@"c:\Dados\Estacoes_SMGS.csv");
            string linha;
            string[] campo;

            while((linha = csv.ReadLine()) != null)
            {
                campo = linha.Split(';');
                dataGridView1.Rows.Add(campo);
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Cliente.colunaTele = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaTele"].Value.ToString();
            Cliente.coluna = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["coluna"].Value.ToString();
            Cliente.colunaNome = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaNome"].Value.ToString();
            Cliente.colunaCNPJ = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaCNPJ"].Value.ToString();
            Cliente.colunaEstacoes = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaEstacoes"].Value.ToString();
            Cliente.colunaM2M = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaM2M"].Value.ToString();
            Cliente.colunaTotal = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaTotal"].Value.ToString();
            Cliente.colunaReferencia = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaReferencia"].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
