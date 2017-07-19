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
    public partial class DodawaniePrzedmiotu : FormularzSzablon
    {
        private ListaPrzedmiotow listaPrzedmiotow;

        public DodawaniePrzedmiotu()
        {
            InitializeComponent();
        }

        public DodawaniePrzedmiotu(Magazyn magazyn, ListaPrzedmiotow listaPrzedmiotow) : base(magazyn)
        {
            this.listaPrzedmiotow = listaPrzedmiotow;
            InitializeComponent();
            SetMdiParent(magazyn);
            poleTekstoweNazwa.KeyPress += PoleTekstoweNazwa_KeyPress;
        }

        private void PoleTekstoweNazwa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int) Keys.Enter)
            {
                przyciskDodaj_Click(this, EventArgs.Empty);
            }
        }

        private void przyciskDodaj_Click(object sender, EventArgs e)
        {
            string name = poleTekstoweNazwa.Text;

            listaPrzedmiotow.DodajPrzedmiotDoMagazynu(name);

            poleTekstoweNazwa.Text = String.Empty;
        }


        private void DodawaniePrzedmiotu_FormClosing(object sender, EventArgs e)
        {
            Magazyn.formularzSzablony[0].Hide();
//            e.Cancel = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Jesteś pewny, że chcesz zamknąć okienko dodawania?", "Zamykanie", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                {
                    e.Cancel = true;
                    break;
                }
                default:
                {
                    e.Cancel = true;
                    Magazyn.formularzSzablony[0].Hide();
                    break;
                }
            }
        }
    }
}