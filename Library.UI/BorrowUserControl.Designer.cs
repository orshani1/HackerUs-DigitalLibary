namespace Library.UI
{
    partial class BorrowUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.bookComboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clientcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BrwdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dueReturningDate = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.dueReturningDate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.bookComboBox2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.clientcomboBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BrwdateTimePicker1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 419);
            this.panel2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Due returning date :";
            // 
            // bookComboBox2
            // 
            this.bookComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookComboBox2.FormattingEnabled = true;
            this.bookComboBox2.Location = new System.Drawing.Point(89, 121);
            this.bookComboBox2.Name = "bookComboBox2";
            this.bookComboBox2.Size = new System.Drawing.Size(284, 24);
            this.bookComboBox2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Book :";
            // 
            // clientcomboBox1
            // 
            this.clientcomboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientcomboBox1.FormattingEnabled = true;
            this.clientcomboBox1.Location = new System.Drawing.Point(89, 63);
            this.clientcomboBox1.Name = "clientcomboBox1";
            this.clientcomboBox1.Size = new System.Drawing.Size(284, 24);
            this.clientcomboBox1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Client :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Borrowing Date :";
            // 
            // BrwdateTimePicker1
            // 
            this.BrwdateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrwdateTimePicker1.Location = new System.Drawing.Point(150, 14);
            this.BrwdateTimePicker1.Name = "BrwdateTimePicker1";
            this.BrwdateTimePicker1.Size = new System.Drawing.Size(223, 22);
            this.BrwdateTimePicker1.TabIndex = 1;
            this.BrwdateTimePicker1.ValueChanged += new System.EventHandler(this.BrwdateTimePicker1_ValueChanged);
            // 
            // dueReturningDate
            // 
            this.dueReturningDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dueReturningDate.AutoSize = true;
            this.dueReturningDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueReturningDate.ForeColor = System.Drawing.Color.White;
            this.dueReturningDate.Location = new System.Drawing.Point(160, 173);
            this.dueReturningDate.Name = "dueReturningDate";
            this.dueReturningDate.Size = new System.Drawing.Size(141, 19);
            this.dueReturningDate.TabIndex = 9;
            this.dueReturningDate.Text = "Due returning date :";
            // 
            // BorrowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "BorrowUserControl";
            this.Size = new System.Drawing.Size(611, 419);
            this.Load += new System.EventHandler(this.BorrowUserControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox bookComboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox clientcomboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BrwdateTimePicker1;
        private System.Windows.Forms.Label dueReturningDate;
    }
}
