using System;
using System.Windows.Forms;

namespace HelloWorldWinForms
{
    public partial class frm_hello : Form
    {
        public frm_hello()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            lbl_hello_message.Text = "Nice to meet you!";
        }

        private void btn_make_it_red_Click(object sender, EventArgs e)
        {
            lbl_hello_message.ForeColor = System.Drawing.Color.Red;
        }
    }
}
