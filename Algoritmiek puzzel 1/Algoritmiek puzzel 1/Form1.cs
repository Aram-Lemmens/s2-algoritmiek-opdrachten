using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmiek_puzzel_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(textBox1.Text);
            int sum = 0;

            for (int i = 0;i < Number; i = i + 3)
            {
                //Console.WriteLine(i);
                sum = sum + i;
            }
            for (int j = 0; j < Number; j = j + 5)
            {
                //Console.WriteLine(i);
                sum = sum + j;
            }
            Console.WriteLine(sum);
        }
    }
}
