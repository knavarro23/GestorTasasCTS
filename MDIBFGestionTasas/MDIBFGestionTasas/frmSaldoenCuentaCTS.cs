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
    public partial class frmSaldoenCuentaCTS : Form
    {
        string strusuario;
        public frmSaldoenCuentaCTS(string usuario)
        {
            InitializeComponent();
            this.strusuario = usuario;
        }
    }
}
