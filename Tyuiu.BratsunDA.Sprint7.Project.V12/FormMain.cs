using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BratsunDA.Sprint7.Project.V12.Lib;

namespace Tyuiu.BratsunDA.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        public void buttonOpenBase_BDA_Click(object sender, EventArgs e)
        {
            openFileDialog_BDA.ShowDialog();
            openFilePath = openFileDialog_BDA.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);


            arrayValues = ds.GetBase(openFilePath);

            buttonViewBase_BDA.Enabled = true;
        }

        public void buttonViewBase_BDA_Click(object sender, EventArgs e)
        {
            dataGridViewBase_BDA.ColumnCount = columns;
            dataGridViewBase_BDA.RowCount = rows;


            dataGridViewBase_BDA.Rows[0].ReadOnly = true;
            dataGridViewBase_BDA.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewBase_BDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetBase(openFilePath);

            buttonFind_BDA.Enabled = true;
            buttonDelete_BDA.Enabled = true;
            buttonEdit_BDA.Enabled = true;
            buttonSave_BDA.Enabled = true;
            buttonGPU_BDA.Enabled = true;
            buttonCPU_BDA.Enabled = true;
            buttonRAM_BDA.Enabled = true;
            buttonAdd_BDA.Enabled = true;
            buttonGPUgr_BDA.Enabled = true;
            buttonCPUgr_BDA.Enabled = true;
        }

        public void buttonDelete_BDA_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBase_BDA.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewBase_BDA.CurrentRow.Index;
                    dataGridViewBase_BDA.Rows.Remove(dataGridViewBase_BDA.Rows[a]);
                    if (dataGridViewBase_BDA.Rows.Count == 1)
                    {
                        dataGridViewBase_BDA.Rows.Clear();
                    }
                }
                if (dataGridViewBase_BDA.Rows.Count <= 1)
                {
                    buttonDelete_BDA.Enabled = false;
                    buttonEdit_BDA.Enabled = false;
                    buttonFind_BDA.Enabled = false;
                }
                if (dataGridViewBase_BDA.Rows.Count > 1)
                {
                    buttonDelete_BDA.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении комплектующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonAdd_BDA_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
        }



        public void FormMain_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void buttonSave_BDA_Click(object sender, EventArgs e)
        {
            saveFileDialog_BDA.FileName = "PC_Base.csv";
            saveFileDialog_BDA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_BDA.ShowDialog();

            string path = saveFileDialog_BDA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewBase_BDA.RowCount;
            int columns = dataGridViewBase_BDA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewBase_BDA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewBase_BDA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonFind_BDA_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewBase_BDA.RowCount; i++)
                {
                    dataGridViewBase_BDA.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewBase_BDA.ColumnCount; j++)
                        if (dataGridViewBase_BDA.Rows[i].Cells[j].Value != null)
                            if (dataGridViewBase_BDA.Rows[i].Cells[j].Value.ToString().Contains(textBoxFind_BDA.Text))
                            {
                                dataGridViewBase_BDA.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGPU_BDA_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewBase_BDA.RowCount; i++)
                {
                    dataGridViewBase_BDA.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewBase_BDA.ColumnCount; j++)
                        if (j == 0)
                            if (dataGridViewBase_BDA.Rows[i].Cells[j].Value.ToString().Contains("gpu"))
                            {
                                dataGridViewBase_BDA.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCPU_BDA_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewBase_BDA.RowCount; i++)
                {
                    dataGridViewBase_BDA.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewBase_BDA.ColumnCount; j++)
                        if (j == 0)
                            if (dataGridViewBase_BDA.Rows[i].Cells[j].Value.ToString().Contains("cpu"))
                            {
                                dataGridViewBase_BDA.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRAM_BDA_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewBase_BDA.RowCount; i++)
                {
                    dataGridViewBase_BDA.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewBase_BDA.ColumnCount; j++)
                        if (j == 0)
                            if (dataGridViewBase_BDA.Rows[i].Cells[j].Value.ToString().Contains("ram"))
                            {
                                dataGridViewBase_BDA.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGPUgr_BDA_Click(object sender, EventArgs e)
        {
            List<double> data = new List<double>();
            List<string> labels = new List<string>(); 

            foreach (DataGridViewRow row in dataGridViewBase_BDA.Rows)
            {
                if (row.Cells[0].Value?.ToString() == "gpu" && double.TryParse(row.Cells[4].Value?.ToString(), out double value))
                {
                    data.Add(value);
                    labels.Add(row.Cells[2].Value?.ToString()); 
                }
            }

            chartGPU.Series.Clear();
            chartGPU.Series.Add("GPU Rate");

            for (int i = 0; i < data.Count; i++)
            {
              
                chartGPU.Series["GPU Rate"].Points.AddXY(labels[i], data[i]);
            }

           
            chartGPU.ChartAreas[0].AxisX.Title = "Видеокарта";
            chartGPU.ChartAreas[0].AxisY.Title = "Производительность";

            chartGPU.Show();

        }

        private void buttonCPUgr_BDA_Click(object sender, EventArgs e)
        {
            List<double> data = new List<double>(); 
            List<string> labels = new List<string>(); 

            foreach (DataGridViewRow row in dataGridViewBase_BDA.Rows)
            {
              
                if (row.Cells[0].Value?.ToString() == "cpu" && double.TryParse(row.Cells[4].Value?.ToString(), out double value))
                {
                    data.Add(value); 
                    labels.Add(row.Cells[2].Value?.ToString()); 
                }
            }

            chartCPU.Series.Clear(); 
            chartCPU.Series.Add("CPU Rate");

            for (int i = 0; i < data.Count; i++)
            {

                chartCPU.Series["CPU Rate"].Points.AddXY(labels[i], data[i]);
            }


            chartCPU.ChartAreas[0].AxisX.Title = "Процессор";
            chartCPU.ChartAreas[0].AxisY.Title = "Производительность";

            chartCPU.Show(); 


        }

        private void buttonEdit_BDA_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewBase_BDA.CurrentRow.Index;
                FormEdit fed = new FormEdit(this);
                fed.comboBoxType_BDA.Text = dataGridViewBase_BDA.Rows[a].Cells[0].Value.ToString();
                fed.textBoxMaker.Text = dataGridViewBase_BDA.Rows[a].Cells[1].Value.ToString();
                fed.textBoxModel.Text = dataGridViewBase_BDA.Rows[a].Cells[2].Value.ToString();
                fed.textBoxCash.Text = dataGridViewBase_BDA.Rows[a].Cells[3].Value.ToString();
                fed.textBoxRaiting.Text = dataGridViewBase_BDA.Rows[a].Cells[4].Value.ToString();
                fed.textBoxGPU.Text = dataGridViewBase_BDA.Rows[a].Cells[5].Value.ToString();
                fed.textBoxCPU.Text = dataGridViewBase_BDA.Rows[a].Cells[6].Value.ToString();
                fed.textBoxCPU2.Text = dataGridViewBase_BDA.Rows[a].Cells[7].Value.ToString();
                fed.textBoxRAM.Text = dataGridViewBase_BDA.Rows[a].Cells[8].Value.ToString();
                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании комплектующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BDA_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }
    }
}
