using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BratsunDA.Sprint7.Project.V12
{
    public partial class FormAdd : Form
    {
        FormMain fmain;
        public FormAdd(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        public void buttonAddPC_BDA_Click(object sender, EventArgs e)
        {
            if ((comboBoxType_BDA.Text == "") || (textBoxModel.Text == ""))
            {
                MessageBox.Show("Введите обязательные характеристики", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fmain.dataGridViewBase_BDA.Rows.Add(comboBoxType_BDA.Text, textBoxMaker.Text, textBoxModel.Text, textBoxCash.Text, textBoxRaiting.Text, textBoxGPU.Text, textBoxCPU.Text, textBoxCPU2.Text, textBoxRAM.Text);
                this.Close();
            }
        }

        private void textBoxRaiting_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxGPU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxCPU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxCPU2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxRAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
