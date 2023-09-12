namespace HelloWorldWinForms
{
    partial class frm_hello
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
            this.lbl_hello_message = new System.Windows.Forms.Label();
            this.btn_hello = new System.Windows.Forms.Button();
            this.btn_make_it_red = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_hello_message
            // 
            this.lbl_hello_message.AutoSize = true;
            this.lbl_hello_message.Location = new System.Drawing.Point(214, 285);
            this.lbl_hello_message.Name = "lbl_hello_message";
            this.lbl_hello_message.Size = new System.Drawing.Size(0, 18);
            this.lbl_hello_message.TabIndex = 1;
            this.lbl_hello_message.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(275, 123);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(123, 47);
            this.btn_hello.TabIndex = 2;
            this.btn_hello.Text = "Hello!";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // btn_make_it_red
            // 
            this.btn_make_it_red.Location = new System.Drawing.Point(459, 123);
            this.btn_make_it_red.Name = "btn_make_it_red";
            this.btn_make_it_red.Size = new System.Drawing.Size(122, 47);
            this.btn_make_it_red.TabIndex = 3;
            this.btn_make_it_red.Text = "Make it Red";
            this.btn_make_it_red.UseVisualStyleBackColor = true;
            this.btn_make_it_red.Click += new System.EventHandler(this.btn_make_it_red_Click);
            // 
            // frm_hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.btn_make_it_red);
            this.Controls.Add(this.btn_hello);
            this.Controls.Add(this.lbl_hello_message);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_hello";
            this.Text = "Hello. Click me!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_hello_message;
        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.Button btn_make_it_red;
    }
}

