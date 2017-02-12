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
    public partial class frmIngresoNetoCTS : Form
    {
        string strusuario;
        public frmIngresoNetoCTS(string usuario)
        {
            InitializeComponent();
            this.strusuario = usuario;
        }
    }
}
