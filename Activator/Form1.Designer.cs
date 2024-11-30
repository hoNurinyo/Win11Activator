namespace Activator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "WinActivator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 24);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "by hoNur";
            // 
            // button1
            // 
            button1.Location = new Point(12, 55);
            button1.Name = "button1";
            button1.Size = new Size(320, 63);
            button1.TabIndex = 2;
            button1.Text = "Windows 11 Etkinleştirme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Form1_Load;
            button1.MouseClick += button1_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(12, 124);
            button2.Name = "button2";
            button2.Size = new Size(320, 30);
            button2.TabIndex = 3;
            button2.Text = "Windows 11 Pro Etkinleştirme";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 160);
            button3.Name = "button3";
            button3.Size = new Size(320, 30);
            button3.TabIndex = 4;
            button3.Text = "Windows 11 Enterprise Etkinleştirme";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.MouseClick += button3_MouseClick;
            // 
            // button4
            // 
            button4.Location = new Point(12, 196);
            button4.Name = "button4";
            button4.Size = new Size(320, 30);
            button4.TabIndex = 5;
            button4.Text = "Windows 11 Home Etkinleştirme";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.MouseClick += button4_MouseClick;
            // 
            // button6
            // 
            button6.Location = new Point(257, 16);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 7;
            button6.Text = "Geri Dön";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.MouseClick += button6_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 461);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
    }
}
