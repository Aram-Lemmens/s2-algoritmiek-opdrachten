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
        //Wanneer we de veelvouden van 3 en 5 van alle gehele getallen onder de 10 uitrekenen krijgen we de getallen 3, 5, 6 en 9. De som van deze vier getallen is 23.
        //Geef de som van alle veelvouden van 3 en 5 onder de 1000.

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // om the fixen moet de getallen die double voor komen niet twee keer er in laten zitten
            int Number = 1000;
            int sum = 0;

            for (int i = 0;i < Number; i = i + 3)
            {
                sum = sum + i;
            }
            for (int j = 0; j < Number; j = j + 5)
            {
                sum = sum + j;
            }
            Console.WriteLine(sum);
        }
    }
}
