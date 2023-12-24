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
    public partial class FormEdit : Form
    {
        FormMain fmain;
        public FormEdit(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonEdit_BDA_Click(object sender, EventArgs e)
        {

            if ((comboBoxType_BDA.Text == "") || (textBoxModel.Text == ""))
            {
                MessageBox.Show("Введите обязательные характеристики", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int a = fmain.dataGridViewBase_BDA.CurrentRow.Index;
                fmain.dataGridViewBase_BDA.Rows[a].Cells[0].Value = comboBoxType_BDA.Text;
                fmain.dataGridViewBase_BDA.Rows[a].Cells[1].Value = textBoxMaker.Text;
                fmain.dataGridViewBase_BDA.Rows[a].Cells[2].Value = textBoxModel.Text;
                fmain.dataGridViewBase_BDA.Rows[a].Cells[3].Value = textBoxCash.Text;
                fmain.dataGridViewBase_BDA.Rows[a].Cells[4].Value = textBoxRaiting.Text;
                fmain.dataGridViewBase_BDA.Rows[a].Cells[5].Value = textBoxGPU.Text;
                fmain.dataGridViewBase_BDA.Rows[a].Cells[6].Value = textBoxCPU.Text;
                fmain.dataGridViewBase_BDA.Rows[a].Cells[7].Value = textBoxCPU2.Text;
                fmain.dataGridViewBase_BDA.Rows[a].Cells[8].Value = textBoxRAM.Text;
                this.Close();
            }

        }

        private void textBoxRaiting_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void textBoxCash_KeyPress_1(object sender, KeyPressEventArgs e)
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
