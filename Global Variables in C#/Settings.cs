using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Variables_in_C_
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Globals.backColour = colorDialog1.Color;
            button1.BackColor = colorDialog1.Color;
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                frm.BackColor= Globals.backColour ;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Globals.foreColour = colorDialog1.Color;
            button2.BackColor = colorDialog1.Color;
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                frm.ForeColor= Globals.foreColour ;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            BackColor = Globals.backColour;
            ForeColor = Globals.foreColour;
            button1.BackColor= BackColor;
            button2.BackColor= ForeColor;
        }
    }
}
