using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upg_finalni_projekt
{
    public partial class My_Games : Form
    {
        public My_Games()
        {
            InitializeComponent();
        }



        private void piskvorky_Click(object sender, EventArgs e)
        {
            Piskvorky piskvorky = new Piskvorky();
            piskvorky.Show();
        }

        private void bugs_Click(object sender, EventArgs e)
        {
            Bugs bugs = new Bugs();
            bugs.Show();
        }

        private void gravityshift_Click(object sender, EventArgs e)
        {
            Gravity_Shift gravityShift = new Gravity_Shift();
            gravityShift.Show();
        }
    }
}
