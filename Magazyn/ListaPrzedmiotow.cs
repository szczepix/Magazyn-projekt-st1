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
    public partial class ListaPrzedmiotow : FormularzSzablon
    {
        public ListaPrzedmiotow()
        {
            InitializeComponent();
        }

        public ListaPrzedmiotow(Magazyn magazyn) : base(magazyn)
        {
            InitializeComponent();
            SetMdiParent(magazyn);
        }
    }
}
