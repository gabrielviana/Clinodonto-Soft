using System;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CLINODONTO_SOFT.classes;
using System.Xml;

namespace CLINODONTO_SOFT.telas.Controle_de_usuarios
{
    public partial class frmBuscardentista : Form
    {

        ArrayList arr = new ArrayList();

        public frmBuscardentista()
        {
            InitializeComponent();

        }
        public void atualiza_grid()
        {
            classDentista den = new classDentista();
            dataGridView1.Rows.Clear();
            arr.Clear();
            try
            {

                arr = den.buscar(txtDentista.Text);
                for (int i = 0; i < arr.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = ((classDentista)arr[i]).Nome;
                    dataGridView1[1, i].Value = ((classDentista)arr[i]).Cro;
                    dataGridView1[2, i].Value = ((classDentista)arr[i]).Cpf;

                }
            }
            catch (Exception e)
            {
                throw e;
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dataGridView1.CurrentRow.Index;


            /*
                       dataGridView1.Rows.Clear();
                       arr.Clear();
                       new frmCadastrardentista(((classDentista)arr[t]).Iddentista.ToString()).ShowDialog();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmCadastrardentista().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmExpediente().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (arr.Count > 0)
            {

                int ind = dataGridView1.CurrentRow.Index;
                new frmCadastrardentista(((classDentista)arr[ind]).Iddentista.ToString()).ShowDialog();
                dataGridView1.Rows.Clear();
                arr.Clear();
            }
            else
            {
                MessageBox.Show("Nenhum dentista está selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arr.Count > 0)
            {
                if (MessageBox.Show("Você deseja realmente excluir este dentista ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    classDentista d = new classDentista();
                    int t = dataGridView1.CurrentRow.Index;
                    string x = d.Deletar(((classDentista)arr[t]).Iddentista.ToString());
                    if (x == "1")
                    {

                        MessageBox.Show("Dentista excluido com sucesso.");
                        atualiza_grid();

                    }
                    else
                    {
                        MessageBox.Show("Não é possivel excluir este dentista\n. já existem dados gravados relativos a ele", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }



            }
            else
            {
                MessageBox.Show("Não há nenhum dentista selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }




        }

        private void frmBuscardentista_Load(object sender, EventArgs e)
        {

            atualiza_grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void frmBuscardentista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txtDentista.Focused == true)
                {
                    atualiza_grid();
                }
            }
        }

    }
}
