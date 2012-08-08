using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CLINODONTO_SOFT.classes;

namespace CLINODONTO_SOFT.telas.Controle_de_usuarios
{
    public partial class frmExpediente : Form
    {
        public frmExpediente()
        {
            InitializeComponent();
        }
        public frmExpediente(int id)
        {
            InitializeComponent();
            classDentista d = new classDentista();
           int x = d.bucarexpediente(id.ToString());
           if (x == 0)
           {
               d.criar_exp(id.ToString());
                    
           }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
  

    }
}
