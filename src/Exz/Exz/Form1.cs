using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exz
{
    public partial class Main : Form
    {
        DialogForm enterForm;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enterForm = new DialogForm();
            BusesContainer buses = new BusesContainer((int)numericUpDown1.Value);
            int[] arr;
            arr = new int[3];
            for(int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                DialogResult result = enterForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Bus bus = new Bus(Convert.ToInt32(enterForm.textBox1.Text), enterForm.textBox2.Text, enterForm.textBox3.Text, Convert.ToInt32(enterForm.textBox1.Text));
                    buses.array_Bas[i] = bus;
                 }
            }
        }
    }
}
