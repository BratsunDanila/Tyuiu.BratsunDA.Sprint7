
namespace Tyuiu.BratsunDA.Sprint7.Project.V12
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddPC_BDA = new System.Windows.Forms.Button();
            this.textBoxMaker = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.textBoxRaiting = new System.Windows.Forms.TextBox();
            this.textBoxGPU = new System.Windows.Forms.TextBox();
            this.textBoxCPU = new System.Windows.Forms.TextBox();
            this.textBoxCPU2 = new System.Windows.Forms.TextBox();
            this.textBoxRAM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxType_BDA = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAddPC_BDA
            // 
            this.buttonAddPC_BDA.Location = new System.Drawing.Point(185, 308);
            this.buttonAddPC_BDA.Name = "buttonAddPC_BDA";
            this.buttonAddPC_BDA.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPC_BDA.TabIndex = 0;
            this.buttonAddPC_BDA.Text = "Добавить";
            this.buttonAddPC_BDA.UseVisualStyleBackColor = true;
            this.buttonAddPC_BDA.Click += new System.EventHandler(this.buttonAddPC_BDA_Click);
            // 
            // textBoxMaker
            // 
            this.textBoxMaker.Location = new System.Drawing.Point(173, 75);
            this.textBoxMaker.Name = "textBoxMaker";
            this.textBoxMaker.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaker.TabIndex = 2;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(173, 102);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 3;
            // 
            // textBoxCash
            // 
            this.textBoxCash.Location = new System.Drawing.Point(173, 129);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(100, 20);
            this.textBoxCash.TabIndex = 4;
            this.textBoxCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCash_KeyPress);
            // 
            // textBoxRaiting
            // 
            this.textBoxRaiting.Location = new System.Drawing.Point(173, 156);
            this.textBoxRaiting.Name = "textBoxRaiting";
            this.textBoxRaiting.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaiting.TabIndex = 5;
            this.textBoxRaiting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRaiting_KeyPress);
            // 
            // textBoxGPU
            // 
            this.textBoxGPU.Location = new System.Drawing.Point(173, 183);
            this.textBoxGPU.Name = "textBoxGPU";
            this.textBoxGPU.Size = new System.Drawing.Size(100, 20);
            this.textBoxGPU.TabIndex = 6;
            this.textBoxGPU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGPU_KeyPress);
            // 
            // textBoxCPU
            // 
            this.textBoxCPU.Location = new System.Drawing.Point(173, 210);
            this.textBoxCPU.Name = "textBoxCPU";
            this.textBoxCPU.Size = new System.Drawing.Size(100, 20);
            this.textBoxCPU.TabIndex = 7;
            this.textBoxCPU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCPU_KeyPress);
            // 
            // textBoxCPU2
            // 
            this.textBoxCPU2.Location = new System.Drawing.Point(173, 237);
            this.textBoxCPU2.Name = "textBoxCPU2";
            this.textBoxCPU2.Size = new System.Drawing.Size(100, 20);
            this.textBoxCPU2.TabIndex = 8;
            this.textBoxCPU2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCPU2_KeyPress);
            // 
            // textBoxRAM
            // 
            this.textBoxRAM.Location = new System.Drawing.Point(173, 264);
            this.textBoxRAM.Name = "textBoxRAM";
            this.textBoxRAM.Size = new System.Drawing.Size(100, 20);
            this.textBoxRAM.TabIndex = 9;
            this.textBoxRAM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRAM_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Добавить комплектующее:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(132, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "*Тип:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Производитель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(112, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "*Модель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Стоимость:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(47, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Производительность:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Частота видеоядра:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Частота процессора:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Кол-во ядер:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Частота ОЗУ:";
            // 
            // comboBoxType_BDA
            // 
            this.comboBoxType_BDA.FormattingEnabled = true;
            this.comboBoxType_BDA.Items.AddRange(new object[] {
            "gpu",
            "cpu",
            "ram"});
            this.comboBoxType_BDA.Location = new System.Drawing.Point(173, 48);
            this.comboBoxType_BDA.Name = "comboBoxType_BDA";
            this.comboBoxType_BDA.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType_BDA.TabIndex = 20;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 351);
            this.Controls.Add(this.comboBoxType_BDA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRAM);
            this.Controls.Add(this.textBoxCPU2);
            this.Controls.Add(this.textBoxCPU);
            this.Controls.Add(this.textBoxGPU);
            this.Controls.Add(this.textBoxRaiting);
            this.Controls.Add(this.textBoxCash);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMaker);
            this.Controls.Add(this.buttonAddPC_BDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новое комплектующее";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddPC_BDA;
        private System.Windows.Forms.TextBox textBoxMaker;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.TextBox textBoxRaiting;
        private System.Windows.Forms.TextBox textBoxGPU;
        private System.Windows.Forms.TextBox textBoxCPU;
        private System.Windows.Forms.TextBox textBoxCPU2;
        private System.Windows.Forms.TextBox textBoxRAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxType_BDA;
    }
}