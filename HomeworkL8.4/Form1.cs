using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkL8._4
{
    public partial class Form1 : Form
    {
        TrueFalse dataBase;
        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dataBase = new TrueFalse(sfd.FileName);
                dataBase.Add("123", true);
                dataBase.Save();
                numNumber.Minimum = 1;
                numNumber.Maximum = 1;
                numNumber.Value = 1;
            }
        }
        private void numNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxQuestion.Text = dataBase[(int)numNumber.Value - 1].text;
            cboxTrue.Checked = dataBase[(int)numNumber.Value - 1].trueFalse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataBase == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            dataBase.Add((dataBase.Count + 1).ToString(), true);
            numNumber.Maximum = dataBase.Count;
            numNumber.Value = dataBase.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (numNumber.Maximum == 1 || dataBase == null) return;
            dataBase.Remove((int)numNumber.Value);
            numNumber.Maximum--;
            if (numNumber.Value > 1) numNumber.Value = numNumber.Value;            
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (dataBase != null) dataBase.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataBase = new TrueFalse(ofd.FileName);
                dataBase.Load();
                numNumber.Minimum = 1;
                numNumber.Maximum = dataBase.Count;
                numNumber.Value = 1;
            }
        }
        
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            dataBase[(int)numNumber.Value - 1].text = tboxQuestion.Text;
            dataBase[(int)numNumber.Value - 1].trueFalse = cboxTrue.Checked;
        }
    }
}
