// *************************************************************************************
// Simple Message Box 1.0
//       davebowlin@gmail.com
//
// Wrote this little class to handle all my messageboxes in a project I'm working on.
// Basically, makes it super fast and easy to create a messagebox and get the dialog
// that is returned (the button the user clicks).
//
// Example use:  smb(string message, string title, integer of which buttons to display);
// *************************************************************************************

using System;
using System.Windows.Forms;

namespace SMB___Simple_Message_Box
{
    public partial class Form1 : Form
    {
        // ****************************************************************
        // Variables
        private int btn = 0;

        private Simple simple = new Simple();  // Instantiate the class.
        // ****************************************************************

        public Form1()
        {
            InitializeComponent();
        }

        //
        //
        //
        // ****************************************************************
        // Pass the information to the Simple.cs class file to be processed.
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DialogResult myanswer = simple.smb(textMessage.Text, textTitle.Text, btn);
            labelChoice.Text = myanswer.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult myanswer = simple.smb(textBox1.Text, textBox2.Text, btn);
            labelChoice.Text = myanswer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult myanswer = simple.smb(textBox3.Text, textBox4.Text, btn);
            labelChoice.Text = myanswer.ToString();
        }

        // ****************************************************************
        //
        //
        //
        // ****************************************************************
        //  Set the btn variable to the proper integer. This determines
        //  which buttons to show.
        private void rdoOK_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                btn = 1;
            }
        }

        private void rdoYesNo_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                btn = 2;
            }
        }

        private void rdoOKCancel_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                btn = 3;
            }
        }

        // ****************************************************************
        //
        //
        //
        // ****************************************************************
        // Clear the textboxes.
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
            textMessage.Focus();
        }

        // ****************************************************************
    }
}