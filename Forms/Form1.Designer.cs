namespace roman_numerals_net
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_roman = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicToRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanToArabicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.btn_convert = new roman_numerals_net.utils.RoundedButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convert Roman To Arabic Numerals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Roman Numerals";
            // 
            // textBox_roman
            // 
            this.textBox_roman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.textBox_roman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_roman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_roman.Location = new System.Drawing.Point(84, 133);
            this.textBox_roman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_roman.Name = "textBox_roman";
            this.textBox_roman.Size = new System.Drawing.Size(418, 27);
            this.textBox_roman.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.practiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 5;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.helpToolStripMenuItem.Text = "help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabicToRomanToolStripMenuItem,
            this.romanToArabicToolStripMenuItem});
            this.practiceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.practiceToolStripMenuItem.Text = "practice";
            // 
            // arabicToRomanToolStripMenuItem
            // 
            this.arabicToRomanToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.arabicToRomanToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.arabicToRomanToolStripMenuItem.Name = "arabicToRomanToolStripMenuItem";
            this.arabicToRomanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.arabicToRomanToolStripMenuItem.Text = "arabic to roman";
            this.arabicToRomanToolStripMenuItem.Click += new System.EventHandler(this.arabicToRomanToolStripMenuItem_Click);
            // 
            // romanToArabicToolStripMenuItem
            // 
            this.romanToArabicToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.romanToArabicToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.romanToArabicToolStripMenuItem.Name = "romanToArabicToolStripMenuItem";
            this.romanToArabicToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.romanToArabicToolStripMenuItem.Text = "roman to arabic";
            this.romanToArabicToolStripMenuItem.Click += new System.EventHandler(this.romanToArabicToolStripMenuItem_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.textBox_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_result.Location = new System.Drawing.Point(84, 222);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(418, 27);
            this.textBox_result.TabIndex = 7;
            this.textBox_result.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arabic Numerals";
            // 
            // label_error
            // 
            this.label_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.label_error.Location = new System.Drawing.Point(82, 163);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(418, 23);
            this.label_error.TabIndex = 8;
            this.label_error.Text = "Error Validation";
            // 
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btn_convert.BorderRadius = 10;
            this.btn_convert.FlatAppearance.BorderSize = 0;
            this.btn_convert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_convert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_convert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btn_convert.Location = new System.Drawing.Point(214, 303);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(155, 43);
            this.btn_convert.TabIndex = 9;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.ConvertNumbers);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(582, 358);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_roman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Roman numerals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_roman;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_error;
        private utils.RoundedButton btn_convert;
        private System.Windows.Forms.ToolStripMenuItem arabicToRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanToArabicToolStripMenuItem;
    }
}

