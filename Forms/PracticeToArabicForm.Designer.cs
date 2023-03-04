namespace roman_numerals_net.Forms
{
    partial class PracticeToArabicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeToArabicForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_number = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.textBox_arabic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_check = new roman_numerals_net.utils.RoundedButton();
            this.btn_next = new roman_numerals_net.utils.RoundedButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.84024F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.15976F));
            this.tableLayoutPanel1.Controls.Add(this.label_number, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_score, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 73);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_number.Location = new System.Drawing.Point(114, 36);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(221, 37);
            this.label_number.TabIndex = 18;
            this.label_number.Text = "number here";
            this.label_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "Your score:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "Your number:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_score.Location = new System.Drawing.Point(114, 0);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(221, 36);
            this.label_score.TabIndex = 17;
            this.label_score.Text = "score here";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_message
            // 
            this.label_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(38)))), ((int)(((byte)(211)))));
            this.label_message.Location = new System.Drawing.Point(12, 276);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(418, 23);
            this.label_message.TabIndex = 21;
            this.label_message.Text = "Message here";
            // 
            // textBox_arabic
            // 
            this.textBox_arabic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_arabic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_arabic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.textBox_arabic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_arabic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_arabic.Location = new System.Drawing.Point(12, 242);
            this.textBox_arabic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_arabic.Name = "textBox_arabic";
            this.textBox_arabic.Size = new System.Drawing.Size(418, 30);
            this.textBox_arabic.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Arabic Numerals";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 49);
            this.label2.TabIndex = 18;
            this.label2.Text = "You will be given a number in Roman numerals, and your task is to convert it to i" +
    "ts equivalent in Arabic numerals.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Practice your knowledge ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btn_check.BorderRadius = 10;
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btn_check.Location = new System.Drawing.Point(99, 323);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(112, 43);
            this.btn_check.TabIndex = 24;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.CheckInput);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btn_next.BorderRadius = 10;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btn_next.Location = new System.Drawing.Point(241, 323);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(112, 43);
            this.btn_next.TabIndex = 23;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.GetNext);
            // 
            // PracticeToArabicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(452, 378);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.textBox_arabic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 420);
            this.Name = "PracticeToArabicForm";
            this.Opacity = 0.99D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice To Arabic";
            this.Load += new System.EventHandler(this.PracticeToArabicForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utils.RoundedButton btn_check;
        private utils.RoundedButton btn_next;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.TextBox textBox_arabic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}