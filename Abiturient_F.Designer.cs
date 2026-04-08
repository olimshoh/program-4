using System.Drawing;
using System.Windows.Forms;

namespace AbiturientApp
{
    partial class Abiturient_F
    {
        private System.ComponentModel.IContainer components = null;

        // Поля ввода - делаем public, чтобы были доступны из Form1
        public System.Windows.Forms.TextBox Familia_TB;
        public System.Windows.Forms.TextBox Shkola_TB;
        public System.Windows.Forms.TextBox Shifr_TB;
        public System.Windows.Forms.TextBox Balli_TB;

        private System.Windows.Forms.Button Ok_B;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Familia_TB = new System.Windows.Forms.TextBox();
            this.Shkola_TB = new System.Windows.Forms.TextBox();
            this.Shifr_TB = new System.Windows.Forms.TextBox();
            this.Balli_TB = new System.Windows.Forms.TextBox();
            this.Ok_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Familia_TB
            // 
            this.Familia_TB.Location = new System.Drawing.Point(169, 20);
            this.Familia_TB.Multiline = true;
            this.Familia_TB.Name = "Familia_TB";
            this.Familia_TB.Size = new System.Drawing.Size(200, 45);
            this.Familia_TB.TabIndex = 1;
            // 
            // Shkola_TB
            // 
            this.Shkola_TB.Location = new System.Drawing.Point(169, 79);
            this.Shkola_TB.Multiline = true;
            this.Shkola_TB.Name = "Shkola_TB";
            this.Shkola_TB.Size = new System.Drawing.Size(200, 45);
            this.Shkola_TB.TabIndex = 3;
            // 
            // Shifr_TB
            // 
            this.Shifr_TB.Location = new System.Drawing.Point(169, 133);
            this.Shifr_TB.Multiline = true;
            this.Shifr_TB.Name = "Shifr_TB";
            this.Shifr_TB.Size = new System.Drawing.Size(200, 45);
            this.Shifr_TB.TabIndex = 5;
            // 
            // Balli_TB
            // 
            this.Balli_TB.Location = new System.Drawing.Point(169, 188);
            this.Balli_TB.Multiline = true;
            this.Balli_TB.Name = "Balli_TB";
            this.Balli_TB.Size = new System.Drawing.Size(200, 45);
            this.Balli_TB.TabIndex = 7;
            // 
            // Ok_B
            // 
            this.Ok_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok_B.Location = new System.Drawing.Point(33, 249);
            this.Ok_B.Name = "Ok_B";
            this.Ok_B.Size = new System.Drawing.Size(130, 61);
            this.Ok_B.TabIndex = 8;
            this.Ok_B.Text = "OK";
            this.Ok_B.Click += new System.EventHandler(this.Ok_B_Click);
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(169, 249);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(200, 61);
            this.Cancel_B.TabIndex = 9;
            this.Cancel_B.Text = "Отмена";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(130, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Школа (1-200):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Шифр (1-300):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Баллы (0-200):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Abiturient_F
            // 
            this.AcceptButton = this.Ok_B;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(392, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Familia_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Shkola_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Shifr_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Balli_TB);
            this.Controls.Add(this.Ok_B);
            this.Controls.Add(this.Cancel_B);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Abiturient_F";
            this.Text = "Ввод данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}