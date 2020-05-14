namespace SMB___Simple_Message_Box
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.rdoOK = new System.Windows.Forms.RadioButton();
            this.rdoYesNo = new System.Windows.Forms.RadioButton();
            this.rdoOKCancel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelChoice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(333, 160);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(88, 28);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display 1";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(62, 37);
            this.textMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(194, 26);
            this.textMessage.TabIndex = 1;
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(62, 65);
            this.textTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(194, 26);
            this.textTitle.TabIndex = 2;
            // 
            // rdoOK
            // 
            this.rdoOK.AutoSize = true;
            this.rdoOK.Checked = true;
            this.rdoOK.Location = new System.Drawing.Point(18, 39);
            this.rdoOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoOK.Name = "rdoOK";
            this.rdoOK.Size = new System.Drawing.Size(49, 22);
            this.rdoOK.TabIndex = 3;
            this.rdoOK.TabStop = true;
            this.rdoOK.Text = "OK";
            this.rdoOK.UseVisualStyleBackColor = true;
            this.rdoOK.CheckedChanged += new System.EventHandler(this.rdoOK_CheckedChanged);
            // 
            // rdoYesNo
            // 
            this.rdoYesNo.AutoSize = true;
            this.rdoYesNo.Location = new System.Drawing.Point(18, 65);
            this.rdoYesNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoYesNo.Name = "rdoYesNo";
            this.rdoYesNo.Size = new System.Drawing.Size(83, 22);
            this.rdoYesNo.TabIndex = 4;
            this.rdoYesNo.Text = "Yes / No";
            this.rdoYesNo.UseVisualStyleBackColor = true;
            this.rdoYesNo.CheckedChanged += new System.EventHandler(this.rdoYesNo_CheckedChanged);
            // 
            // rdoOKCancel
            // 
            this.rdoOKCancel.AutoSize = true;
            this.rdoOKCancel.Location = new System.Drawing.Point(18, 92);
            this.rdoOKCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoOKCancel.Name = "rdoOKCancel";
            this.rdoOKCancel.Size = new System.Drawing.Size(110, 22);
            this.rdoOKCancel.TabIndex = 5;
            this.rdoOKCancel.Text = "OK / Cancel";
            this.rdoOKCancel.UseVisualStyleBackColor = true;
            this.rdoOKCancel.CheckedChanged += new System.EventHandler(this.rdoOKCancel_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Msg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoOK);
            this.groupBox1.Controls.Add(this.rdoYesNo);
            this.groupBox1.Controls.Add(this.rdoOKCancel);
            this.groupBox1.Location = new System.Drawing.Point(333, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(175, 126);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MessageBox Buttons";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Display 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Display 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Msg:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 135);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 26);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 164);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 26);
            this.textBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Msg:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 242);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 26);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(62, 270);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 26);
            this.textBox4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Title:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(333, 284);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 26);
            this.button3.TabIndex = 13;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "User choice:";
            // 
            // labelChoice
            // 
            this.labelChoice.AutoSize = true;
            this.labelChoice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoice.ForeColor = System.Drawing.Color.Maroon;
            this.labelChoice.Location = new System.Drawing.Point(112, 317);
            this.labelChoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChoice.Name = "labelChoice";
            this.labelChoice.Size = new System.Drawing.Size(0, 18);
            this.labelChoice.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "messagebox 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "messagebox 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "messagebox 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 343);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelChoice);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisplay);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Simple Message Box Class";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.RadioButton rdoOK;
        private System.Windows.Forms.RadioButton rdoYesNo;
        private System.Windows.Forms.RadioButton rdoOKCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelChoice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
    }
}

