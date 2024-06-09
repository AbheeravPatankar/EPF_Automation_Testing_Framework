namespace TestWinforms
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listedFiles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.callAPIbtn = new System.Windows.Forms.Button();
            this.testAPI_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Input Directory";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(851, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "....";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.selectInputDir);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(851, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = ".....";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.selectOutputDir);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(372, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(453, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select output Directory";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(372, 348);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(453, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select expected output Directory";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(851, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = ".....";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.selectExpectedOutputDir);
            // 
            // listedFiles
            // 
            this.listedFiles.Location = new System.Drawing.Point(282, 452);
            this.listedFiles.Multiline = true;
            this.listedFiles.Name = "listedFiles";
            this.listedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listedFiles.Size = new System.Drawing.Size(492, 203);
            this.listedFiles.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selected Files";
            // 
            // callAPIbtn
            // 
            this.callAPIbtn.BackColor = System.Drawing.Color.Lime;
            this.callAPIbtn.Location = new System.Drawing.Point(911, 465);
            this.callAPIbtn.Name = "callAPIbtn";
            this.callAPIbtn.Size = new System.Drawing.Size(142, 55);
            this.callAPIbtn.TabIndex = 12;
            this.callAPIbtn.Text = "Generate Output Files";
            this.callAPIbtn.UseVisualStyleBackColor = false;
            this.callAPIbtn.Click += new System.EventHandler(this.generateOutput);
            // 
            // testAPI_btn
            // 
            this.testAPI_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.testAPI_btn.Location = new System.Drawing.Point(911, 580);
            this.testAPI_btn.Name = "testAPI_btn";
            this.testAPI_btn.Size = new System.Drawing.Size(142, 55);
            this.testAPI_btn.TabIndex = 13;
            this.testAPI_btn.Text = "Test API";
            this.testAPI_btn.UseVisualStyleBackColor = false;
            this.testAPI_btn.Click += new System.EventHandler(this.testAPI);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1204, 725);
            this.Controls.Add(this.testAPI_btn);
            this.Controls.Add(this.callAPIbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listedFiles);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox listedFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button callAPIbtn;
        private System.Windows.Forms.Button testAPI_btn;
    }

}
