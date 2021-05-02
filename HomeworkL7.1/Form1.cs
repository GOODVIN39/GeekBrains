using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace HomeworkL7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
            label3.Text = (int.Parse(label3.Text) + 1).ToString();
            if (label1.Text == label6.Text)
            {
                MessageBox.Show("Поздравляю вы победили!");
            }
        }
        public void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) * 2).ToString();
            label3.Text = (int.Parse(label3.Text) + 1).ToString();
            if (label1.Text == label6.Text)
            {
                MessageBox.Show("Поздравляю вы победили!");
                this.Close();
            }
        }
        public void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label3.Text = (int.Parse(label3.Text) + 1).ToString();
            
        }
        public void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            Random r = new Random();
            int count = r.Next(200);
            MessageBox.Show($"Получите число: {count}");
            button4.Visible = false;
            label6.Text = Convert.ToString(count);            
        }

        
    }
}
