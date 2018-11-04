using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chien_HuaWang_Sec001_Exercise1
{
    public partial class Form1_Load : Form
    {
        public Form1_Load()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e) 
        {
            listBox1.Items.Clear();
            LinkedList<double> doubleList;
            doubleList = new LinkedList<double>();
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                double number;
                number = random.Next(11, 99) + random.NextDouble();
                doubleList.AddLast(number);
                listBox1.Items.Add(number.ToString());
            }
        }
    }
}
