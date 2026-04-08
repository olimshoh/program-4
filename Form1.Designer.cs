using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AbiturientApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxAbits;
        private Button buttonAdd;
        private Button buttonChange;
        private Button buttonDel;
        private Label label1;

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
            this.listBoxAbits = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deystvie_MS = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Del_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Load_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Calc_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_D = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_TSB = new System.Windows.Forms.ToolStripButton();
            this.Change_TSB = new System.Windows.Forms.ToolStripButton();
            this.Del_TSB = new System.Windows.Forms.ToolStripButton();
            this.Load_TSB = new System.Windows.Forms.ToolStripButton();
            this.Save_TSB = new System.Windows.Forms.ToolStripButton();
            this.Calc_TSB = new System.Windows.Forms.ToolStripButton();
            this.load_b = new System.Windows.Forms.Button();
            this.save_b = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.calc_b = new System.Windows.Forms.Button();
            this.Open_D = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Familia_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.Shkola_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.Ball_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.Shifr_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAbits
            // 
            this.listBoxAbits.Location = new System.Drawing.Point(12, 85);
            this.listBoxAbits.Name = "listBoxAbits";
            this.listBoxAbits.Size = new System.Drawing.Size(250, 212);
            this.listBoxAbits.TabIndex = 0;
            this.listBoxAbits.SelectedIndexChanged += new System.EventHandler(this.listBoxAbits_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.Location = new System.Drawing.Point(268, 85);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChange.Location = new System.Drawing.Point(268, 121);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(100, 30);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDel.Location = new System.Drawing.Point(268, 157);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 30);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список абитуриентов:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deystvie_MS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deystvie_MS
            // 
            this.deystvie_MS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_TSMI,
            this.Change_TSMI,
            this.Del_TSMI,
            this.Load_TSMI,
            this.Save_TSMI,
            this.Calc_TSMI});
            this.deystvie_MS.Name = "deystvie_MS";
            this.deystvie_MS.Size = new System.Drawing.Size(70, 20);
            this.deystvie_MS.Text = "Действие";
            // 
            // Add_TSMI
            // 
            this.Add_TSMI.Name = "Add_TSMI";
            this.Add_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Add_TSMI.Text = "Добавить";
            this.Add_TSMI.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Change_TSMI
            // 
            this.Change_TSMI.Name = "Change_TSMI";
            this.Change_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Change_TSMI.Text = "Изменить";
            this.Change_TSMI.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // Del_TSMI
            // 
            this.Del_TSMI.Name = "Del_TSMI";
            this.Del_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Del_TSMI.Text = "Удалить";
            this.Del_TSMI.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Load_TSMI
            // 
            this.Load_TSMI.Name = "Load_TSMI";
            this.Load_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Load_TSMI.Text = "Загрузить";
            this.Load_TSMI.Click += new System.EventHandler(this.load_b_Click);
            // 
            // Save_TSMI
            // 
            this.Save_TSMI.Name = "Save_TSMI";
            this.Save_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Save_TSMI.Text = "Сохранить";
            this.Save_TSMI.Click += new System.EventHandler(this.save_b_Click);
            // 
            // Calc_TSMI
            // 
            this.Calc_TSMI.Name = "Calc_TSMI";
            this.Calc_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Calc_TSMI.Text = "Расчет";
            this.Calc_TSMI.Click += new System.EventHandler(this.calc_b_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_TSB,
            this.Change_TSB,
            this.Del_TSB,
            this.Load_TSB,
            this.Save_TSB,
            this.Calc_TSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(635, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add_TSB
            // 
            this.Add_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_TSB.Image = global::WindowsFormsApp9.Properties.Resources._047add1_99902;
            this.Add_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_TSB.Name = "Add_TSB";
            this.Add_TSB.Size = new System.Drawing.Size(23, 22);
            this.Add_TSB.Text = "add";
            this.Add_TSB.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Change_TSB
            // 
            this.Change_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Change_TSB.Image = global::WindowsFormsApp9.Properties.Resources.png_transparent_basic_ui_essential_interface_app_edit_pencil_ui_essentials_icon;
            this.Change_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Change_TSB.Name = "Change_TSB";
            this.Change_TSB.Size = new System.Drawing.Size(23, 22);
            this.Change_TSB.Text = "Change";
            this.Change_TSB.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // Del_TSB
            // 
            this.Del_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Del_TSB.Image = global::WindowsFormsApp9.Properties.Resources.img_311777;
            this.Del_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Del_TSB.Name = "Del_TSB";
            this.Del_TSB.Size = new System.Drawing.Size(23, 22);
            this.Del_TSB.Text = "Delate";
            this.Del_TSB.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Load_TSB
            // 
            this.Load_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Load_TSB.Image = global::WindowsFormsApp9.Properties.Resources.download_file_folder_document_storage_down_load_loading_save_doc_organize_portfolio_point_pointer_paper_svg_sign_icon_shape_outline_black_white_vector;
            this.Load_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Load_TSB.Name = "Load_TSB";
            this.Load_TSB.Size = new System.Drawing.Size(23, 22);
            this.Load_TSB.Text = "Load";
            this.Load_TSB.Click += new System.EventHandler(this.load_b_Click);
            // 
            // Save_TSB
            // 
            this.Save_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save_TSB.Image = global::WindowsFormsApp9.Properties.Resources.save_icon_for_your_website_design_logo_app_ui_free_vector;
            this.Save_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_TSB.Name = "Save_TSB";
            this.Save_TSB.Size = new System.Drawing.Size(23, 22);
            this.Save_TSB.Text = "Save";
            this.Save_TSB.Click += new System.EventHandler(this.save_b_Click);
            // 
            // Calc_TSB
            // 
            this.Calc_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Calc_TSB.Image = global::WindowsFormsApp9.Properties.Resources._7675390;
            this.Calc_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Calc_TSB.Name = "Calc_TSB";
            this.Calc_TSB.Size = new System.Drawing.Size(23, 22);
            this.Calc_TSB.Text = "Calc";
            this.Calc_TSB.Click += new System.EventHandler(this.calc_b_Click);
            // 
            // load_b
            // 
            this.load_b.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.load_b.Location = new System.Drawing.Point(268, 193);
            this.load_b.Name = "load_b";
            this.load_b.Size = new System.Drawing.Size(100, 30);
            this.load_b.TabIndex = 6;
            this.load_b.Text = "Загрузить";
            this.load_b.UseVisualStyleBackColor = false;
            this.load_b.Click += new System.EventHandler(this.load_b_Click);
            // 
            // save_b
            // 
            this.save_b.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save_b.Location = new System.Drawing.Point(268, 229);
            this.save_b.Name = "save_b";
            this.save_b.Size = new System.Drawing.Size(100, 30);
            this.save_b.TabIndex = 7;
            this.save_b.Text = "Сохранить";
            this.save_b.UseVisualStyleBackColor = false;
            this.save_b.Click += new System.EventHandler(this.save_b_Click);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(377, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 212);
            this.listBox1.TabIndex = 8;
            // 
            // calc_b
            // 
            this.calc_b.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calc_b.Location = new System.Drawing.Point(268, 269);
            this.calc_b.Name = "calc_b";
            this.calc_b.Size = new System.Drawing.Size(100, 28);
            this.calc_b.TabIndex = 9;
            this.calc_b.Text = "Расчет";
            this.calc_b.UseVisualStyleBackColor = false;
            this.calc_b.Click += new System.EventHandler(this.calc_b_Click);
            // 
            // Open_D
            // 
            this.Open_D.FileName = "OpenFile";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Familia_TSSL,
            this.Shkola_TSSL,
            this.Ball_TSSL,
            this.Shifr_TSSL});
            this.statusStrip1.Location = new System.Drawing.Point(212, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(194, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Familia_TSSL
            // 
            this.Familia_TSSL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Familia_TSSL.Name = "Familia_TSSL";
            this.Familia_TSSL.Size = new System.Drawing.Size(58, 17);
            this.Familia_TSSL.Text = "Фамилия";
            // 
            // Shkola_TSSL
            // 
            this.Shkola_TSSL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Shkola_TSSL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Shkola_TSSL.Name = "Shkola_TSSL";
            this.Shkola_TSSL.Size = new System.Drawing.Size(44, 17);
            this.Shkola_TSSL.Text = "Школа";
            // 
            // Ball_TSSL
            // 
            this.Ball_TSSL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Ball_TSSL.Name = "Ball_TSSL";
            this.Ball_TSSL.Size = new System.Drawing.Size(34, 17);
            this.Ball_TSSL.Text = "Балл";
            // 
            // Shifr_TSSL
            // 
            this.Shifr_TSSL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Shifr_TSSL.Name = "Shifr_TSSL";
            this.Shifr_TSSL.Size = new System.Drawing.Size(41, 17);
            this.Shifr_TSSL.Text = "Шифр";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(374, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Форматирование список абитуриентов:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(635, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.calc_b);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.save_b);
            this.Controls.Add(this.load_b);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAbits);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Абитуриенты";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MenuStrip menuStrip1;
        private SaveFileDialog Save_D;
        private ToolStrip toolStrip1;
        private Button load_b;
        private Button save_b;
        private ListBox listBox1;
        private Button calc_b;
        private ToolStripButton Add_TSB;
        private ToolStripButton Change_TSB;
        private ToolStripButton Del_TSB;
        private ToolStripButton Load_TSB;
        private ToolStripButton Save_TSB;
        private ToolStripButton Calc_TSB;
        private OpenFileDialog Open_D;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem deystvie_MS;
        private Label label2;
        private ToolStripMenuItem Add_TSMI;
        private ToolStripMenuItem Change_TSMI;
        private ToolStripMenuItem Del_TSMI;
        private ToolStripMenuItem Load_TSMI;
        private ToolStripMenuItem Save_TSMI;
        private ToolStripStatusLabel Familia_TSSL;
        private ToolStripStatusLabel Shkola_TSSL;
        private ToolStripStatusLabel Ball_TSSL;
        private ToolStripStatusLabel Shifr_TSSL;
        private ToolStripMenuItem Calc_TSMI;
    }
}