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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Globals.stringValue = textBox1.Text;
            Form2 frm = new Form2();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Globals.backColour;
            ForeColor = Globals.foreColour;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
