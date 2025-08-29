namespace scan_cino_a680_df
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
            txtCode = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.BackColor = SystemColors.Info;
            txtCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(130, 42);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.ScrollBars = ScrollBars.Vertical;
            txtCode.Size = new Size(266, 159);
            txtCode.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Scanned code:\r\n";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 78);
            button1.Name = "button1";
            button1.Size = new Size(92, 40);
            button1.TabIndex = 2;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 141);
            button2.Name = "button2";
            button2.Size = new Size(92, 40);
            button2.TabIndex = 3;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(439, 51);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 4;
            label2.Text = "Disconnected";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 24);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "State:";
            // 
            // button3
            // 
            button3.Location = new Point(463, 97);
            button3.Name = "button3";
            button3.Size = new Size(92, 40);
            button3.TabIndex = 6;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 302);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}
