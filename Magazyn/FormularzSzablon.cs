using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class FormularzSzablon : Form
    {
        public FormularzSzablon()
        {
            InitializeComponent();
        }

        public FormularzSzablon(Magazyn magazyn)
        {
            InitializeComponent();
            SetMdiParent(magazyn);
            Show();
        }

        protected void SetMdiParent(Magazyn magazyn)
        {
            this.MdiParent = magazyn;
        }
    }
}
