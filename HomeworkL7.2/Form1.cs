using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkL7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Random()
        {
            Random rand = new Random();
            int count = rand.Next(1, 10);
            return count;
        }
        public int Value()
        {
            int b;
            var a = int.TryParse(textBox1.Text, out b);
            return b;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (Random() == Value())
            {
                MessageBox.Show("Вы угадали");
                this.Close();
            }            
            else if (Value() > 10) MessageBox.Show("Введите число меньше или равно 10");            
            else if (Value() < 1) MessageBox.Show("Введите число больше или равно 1");      
        }        
    }
}
