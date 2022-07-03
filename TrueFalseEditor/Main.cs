using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseEditor
{
    public partial class Main : Form
    {

        TrueFalseDataBase dataBase;


        public Main()
        {
            InitializeComponent();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dataBase = new TrueFalseDataBase(dlg.FileName);
                dataBase.Add("Земля круглая?", true);
                dataBase.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dataBase = new TrueFalseDataBase(dlg.FileName);
                dataBase.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = dataBase.Count;
                nudNumber.Value = 1;

            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            dataBase.Save();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tbQuestion.Text = dataBase[(int)nudNumber.Value - 1].Text;
            cbTrue.Checked = dataBase[(int)nudNumber.Value - 1].TrueFalse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataBase.Add($"#{dataBase.Count + 1}", true);
            nudNumber.Maximum = dataBase.Count;
            nudNumber.Value = dataBase.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataBase.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
            nudNumber.Value--;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataBase[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            dataBase[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            if (gameForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(gameForm.Data);
                
            }
        }
    }
}
