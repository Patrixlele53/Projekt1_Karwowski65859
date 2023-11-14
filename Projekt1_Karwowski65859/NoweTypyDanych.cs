using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1_Karwowski65859
{
    public partial class pkNoweTypyDanych : Form
    {
        bool[] pkStanAktywnosciStronZakladki =
       {true, true, true, };

        public pkNoweTypyDanych()
        {
            InitializeComponent();
        }

        private void pkZakladki_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((e.TabPage == pkZakladki.TabPages[0]) &&
                (pkStanAktywnosciStronZakladki[0]))
            {
                pkStanAktywnosciStronZakladki[1] = true;
                pkStanAktywnosciStronZakladki[2] = true;
                pkZakladki.SelectedTab = pkKokpit;
            }
            else

            if ((e.TabPage == pkZakladki.TabPages[1]) &&
                (pkStanAktywnosciStronZakladki[1]))
            {
                pkStanAktywnosciStronZakladki[2] = false;
                pkZakladki.SelectedIndex = 1;
            }
            else
                if ((e.TabPage == pkZakladki.TabPages[2]) &&
                (pkStanAktywnosciStronZakladki[2]))
            {
                pkStanAktywnosciStronZakladki[1] = false;
                pkZakladki.SelectedIndex = 2;
            }

            else
                e.Cancel = true;
        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}