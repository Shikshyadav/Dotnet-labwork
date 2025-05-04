using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            // Instantiate the Register form correctly
            Register registerForm = new Register();
            registerForm.TopLevel = false;
            registerForm.FormBorderStyle = FormBorderStyle.None;
            registerForm.Dock = DockStyle.Fill;

            // Add to panel2 and show
            panel2.Controls.Add(registerForm);
            registerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            // Instantiate the Register form correctly
            panel2.Controls.Clear();

            Login loginForm = new Login();  // 👈 Make sure Login.cs exists
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;

            panel2.Controls.Add(loginForm);
            loginForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Calculator calculatorForm = new Calculator();  // 👈 Make sure Calculator.cs exists
            calculatorForm.TopLevel = false;
            calculatorForm.FormBorderStyle = FormBorderStyle.None;
            calculatorForm.Dock = DockStyle.Fill;

            panel2.Controls.Add(calculatorForm);
            calculatorForm.Show();
        }

       

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Visible = true;
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.Visible = false;
        }

        
    }
}
