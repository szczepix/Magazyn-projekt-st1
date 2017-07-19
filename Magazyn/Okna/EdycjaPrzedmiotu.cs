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
    public partial class EdycjaPrzedmiotu : FormularzSzablon
    {
        public EdycjaPrzedmiotu()
        {
            InitializeComponent();
        }

        public EdycjaPrzedmiotu(Magazyn magazyn) : base(magazyn)
        {
            
            InitializeComponent();
            SetMdiParent(magazyn);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            e.Cancel = true;
            Magazyn.formularzSzablony[1].Hide();
        }
    }
}
