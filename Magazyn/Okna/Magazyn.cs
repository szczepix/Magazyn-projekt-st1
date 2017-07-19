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
    /// <summary>
    /// Główne okno aplikacji
    /// </summary>
    public partial class Magazyn : Form
    {
        /// <summary>
        /// statyczne pole z formularzami, które są utworzone w głównym oknie
        /// </summary>
        public static FormularzSzablon[] formularzSzablony;

        /// <summary>
        /// Konstruktor bezparametrowy głównego okna aplikacji
        /// </summary>
        public Magazyn()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            Show();

            formularzSzablony = new FormularzSzablon[2];
            formularzSzablony[0] = new DodawaniePrzedmiotu(this, new ListaPrzedmiotow(this));
            formularzSzablony[0].Hide();
            formularzSzablony[1] = new EdycjaPrzedmiotu(this);
            formularzSzablony[1].Hide();

            /*using (var ctx = new Model1())
            {
                var prod = new Produkt("AAC");


                try
                {
                    ctx.Produkty.Add(prod);
                }
                catch (Exception e)
                {
                   // MessageBox.Show(e.InnerException.ToString());
                    MessageBox.Show(e.ToString());
                    return;
                }

                

                ctx.SaveChanges();

                MessageBox.Show("Dodano do bazy");
            }*/

            /*using (var ctx = new Model1())
            {
                var prod = (from p in ctx.Produkty where p.ProduktName == "AAB" select p).SingleOrDefault<Produkt>();

                MessageBox.Show("nasz wynik = " + prod.ProduktName);
            }*/

            /*using (var ctx = new Model1())
            {
               
                Produkt prod = (from p in ctx.Produkty where p.ProduktName == "AAB" select p).Single<Produkt>();

                prod.ProduktName = "CCC";

                ctx.SaveChanges();

                MessageBox.Show("Nazwa zmieniona!");
            }*/

            /*using (var ctx = new Model1())
            {
                var prod = (from p in ctx.Produkty where p.ProduktName == "AAB" select p).SingleOrDefault<Produkt>();

                ctx.Produkty.Remove(prod);
                MessageBox.Show("Produkt usuniety");
            }*/


        }


    }
}