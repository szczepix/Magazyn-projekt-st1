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
    public partial class Magazyn : Form
    {
        public Magazyn()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            Show();

            FormularzSzablon[] formularzSzablony = new FormularzSzablon[3];
            formularzSzablony[0] = new ListaPrzedmiotow(this);
            formularzSzablony[1] = new DodawaniePrzedmiotu(this);
            formularzSzablony[2] = new EdycjaPrzedmiotu(this);

        }
    }
}
