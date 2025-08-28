namespace isConnected_handle
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
            btn_Connect = new Button();
            label1 = new Label();
            btn_Disconnect = new Button();
            SuspendLayout();
            // 
            // btn_Connect
            // 
            btn_Connect.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Connect.Location = new Point(73, 95);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(124, 37);
            btn_Connect.TabIndex = 0;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(274, 132);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 1;
            label1.Text = "not connect";
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Disconnect.Location = new Point(73, 156);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(124, 39);
            btn_Disconnect.TabIndex = 2;
            btn_Disconnect.Text = "Disconnect";
            btn_Disconnect.UseVisualStyleBackColor = true;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 296);
            Controls.Add(btn_Disconnect);
            Controls.Add(label1);
            Controls.Add(btn_Connect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Connect;
        private Label label1;
        private Button btn_Disconnect;
    }
}
