namespace CSVFileEditor
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.btn_read_file = new System.Windows.Forms.Button();
            this.btn_save_file = new System.Windows.Forms.Button();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbx_people = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_read_file
            // 
            this.btn_read_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read_file.ForeColor = System.Drawing.Color.Blue;
            this.btn_read_file.Location = new System.Drawing.Point(300, 396);
            this.btn_read_file.Name = "btn_read_file";
            this.btn_read_file.Size = new System.Drawing.Size(241, 42);
            this.btn_read_file.TabIndex = 3;
            this.btn_read_file.Text = "Read CSV file";
            this.btn_read_file.UseVisualStyleBackColor = true;
            this.btn_read_file.Click += new System.EventHandler(this.btn_read_file_Click);
            // 
            // btn_save_file
            // 
            this.btn_save_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_file.ForeColor = System.Drawing.Color.Red;
            this.btn_save_file.Location = new System.Drawing.Point(547, 396);
            this.btn_save_file.Name = "btn_save_file";
            this.btn_save_file.Size = new System.Drawing.Size(241, 42);
            this.btn_save_file.TabIndex = 4;
            this.btn_save_file.Text = "Save to File";
            this.btn_save_file.UseVisualStyleBackColor = true;
            this.btn_save_file.Click += new System.EventHandler(this.btn_save_file_Click);
            // 
            // tbx_name
            // 
            this.tbx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_name.Location = new System.Drawing.Point(44, 59);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(241, 26);
            this.tbx_name.TabIndex = 0;
            // 
            // tbx_email
            // 
            this.tbx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_email.Location = new System.Drawing.Point(44, 116);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(241, 26);
            this.tbx_email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-mail";
            // 
            // lbx_people
            // 
            this.lbx_people.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_people.FormattingEnabled = true;
            this.lbx_people.ItemHeight = 20;
            this.lbx_people.Location = new System.Drawing.Point(300, 59);
            this.lbx_people.Name = "lbx_people";
            this.lbx_people.Size = new System.Drawing.Size(488, 324);
            this.lbx_people.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbx_people);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.btn_save_file);
            this.Controls.Add(this.btn_read_file);
            this.Name = "Form1";
            this.Text = "CSV Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_read_file;
        private System.Windows.Forms.Button btn_save_file;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbx_people;
    }
}

