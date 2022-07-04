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

        private bool checkFile = false;

        TrueFalseDataBase dataBase;


        public Main()
        {
            InitializeComponent();
            labelAbout.Visible = false;
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            checkFile = true;

            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                dataBase = new TrueFalseDataBase(dlg.FileName);
                
                dataBase.Add("#1", true);
                dataBase.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            checkFile = true;

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
            if (checkFile)
            {
                dataBase.Save();
            }
            else
            {
                MessageBox.Show("You need to create / open a file first", "File is missing", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
            }
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (checkFile)
            {
                tbQuestion.Text = dataBase[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = dataBase[(int)nudNumber.Value - 1].TrueFalse;
            }
            else
            {
                MessageBox.Show("You need to create / open a file first", "File is missing", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkFile)
            {
                dataBase.Add($"#{dataBase.Count + 1}", true);
                nudNumber.Maximum = dataBase.Count;
                nudNumber.Value = dataBase.Count;
            }
            else
            {
                MessageBox.Show("You need to create / open a file first", "File is missing", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkFile)
            {
                if ((nudNumber.Value < 2))
                {
                    MessageBox.Show(@"You can't delete the first element.
You can only change it", "Deletion error", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                }
                else
                {
                    dataBase.Remove((int)nudNumber.Value - 1);
                    nudNumber.Maximum--;
                    if (!(nudNumber.Value < 2))
                    {
                        nudNumber.Value--;
                    }

                }

            }
            else
            {
                MessageBox.Show("You need to create / open a file first", "File is missing", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkFile)
            {
                dataBase[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                dataBase[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
            }
            else
            {
                MessageBox.Show("You need to create / open a file first", "File is missing", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
            }

        }

        private void tsbAbout_Click(object sender, EventArgs e)
        {
            labelAbout.Visible = true;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            labelAbout.Visible = false;
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
                if (checkFile)
                {
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    dataBase = new TrueFalseDataBase(dlg.FileName);
                    dataBase.Save();
                }
                }
                else
                {
                    MessageBox.Show("You need to create / open a file first", "File is missing", MessageBoxButtons.OK,
        MessageBoxIcon.Information);
                }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
