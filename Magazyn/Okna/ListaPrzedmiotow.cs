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
        private static List<Produkt> Produkty { get; set; } = new List<Produkt>();

        public ListaPrzedmiotow()
        {
            InitializeComponent();
        }

        public ListaPrzedmiotow(Magazyn magazyn) : base(magazyn)
        {
            InitializeComponent();
            SetMdiParent(magazyn);
            OdswiezListePrzedmiotowPoDodaniu();
        }

        public void DodajPrzedmiotDoMagazynu(string name)
        {
            if (name == String.Empty)
            {
                MessageBox.Show("Proszę podać nazwę przedmiotu!");
                return;
            }
            Produkt p = new Produkt(name);

            using (var ctx = new Model1())
            {
                try
                {
                    ctx.Produkty.Add(p);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return;
                }

                ctx.SaveChanges();
                MessageBox.Show("Dodano do bazy");
            }
            OdswiezListePrzedmiotowPoDodaniu();
        }

        public void OdswiezListePrzedmiotowPoDodaniu()
        {
            using (var ctx = new Model1())
            {
                List<Produkt> prodList = (from p in ctx.Produkty select p).ToList<Produkt>();

                foreach (var VARIABLE in prodList)
                {
                    if (!listBoxPrzedmioty.Items.Contains(VARIABLE.ProduktName))
                    {
                        listBoxPrzedmioty.Items.Add(VARIABLE.ProduktName);
                    }
                }
            }
        }

        public void OdswiezListePrzedmiotowPoUsunieciu()
        {
            using (var ctx = new Model1())
            {
                List<Produkt> prodList = (from p in ctx.Produkty select p).ToList<Produkt>();

                try
                {
                    foreach (var produktListy in listBoxPrzedmioty.Items)
                    {
                        Produkt produkt = new Produkt(produktListy.ToString());

                        if (!prodList.Contains(produkt))
                        {
                            listBoxPrzedmioty.Items.Remove(produkt.ProduktName);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Magazyn.formularzSzablony[0].Show();
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxPrzedmioty.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać przedmiot do edycji!");
                return;
            }

            Magazyn.formularzSzablony[1].Show();
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nazwaPrzedmiotu = listBoxPrzedmioty.SelectedItem.ToString();

            using (var ctx = new Model1())
            {
                var prod = (from p in ctx.Produkty where p.ProduktName == nazwaPrzedmiotu select p)
                    .SingleOrDefault<Produkt>();

                ctx.Produkty.Remove(prod);
                ctx.SaveChanges();

                MessageBox.Show("Produkt: " + prod.ProduktName + " został usunięty!");
            }
            OdswiezListePrzedmiotowPoUsunieciu();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            e.Cancel = true;
            MessageBox.Show("Nie można zamykać listy przedmiotów.\nMożna ją wylko zminimalizować.");
            //            this.WindowState = FormWindowState.Minimized;
        }
    }
}