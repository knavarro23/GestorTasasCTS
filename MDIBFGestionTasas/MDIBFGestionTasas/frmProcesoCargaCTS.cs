using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIBFGestionTasas
{
    public partial class frmProcesoCargaCTS : Form
    {
        int intretorno = 0;
        string strusuario;
        public frmProcesoCargaCTS(string usuario)
        {
            InitializeComponent();
            this.strusuario = usuario;
        }

        private void frmProcesoCargaCTS_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

       
    }
}
