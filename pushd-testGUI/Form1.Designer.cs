namespace pushd_testGUI
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
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            textBox1 = new TextBox();
            Papercut_btn = new Button();
            Adobe_btn = new Button();
            Sophos_btn = new Button();
            Splashtop_btn = new Button();
            Cloudflare_btn = new Button();
            Office365_btn = new Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(12, 77);
            button7.Name = "button7";
            button7.Size = new Size(166, 55);
            button7.TabIndex = 6;
            button7.Text = "P.A.S.S.C.O";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(184, 77);
            button8.Name = "button8";
            button8.Size = new Size(166, 55);
            button8.TabIndex = 7;
            button8.Text = "Residents";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(356, 77);
            button9.Name = "button9";
            button9.Size = new Size(166, 55);
            button9.TabIndex = 8;
            button9.Text = "Laptop";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(528, 77);
            button10.Name = "button10";
            button10.Size = new Size(166, 55);
            button10.TabIndex = 9;
            button10.Text = "Executive";
            button10.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 149);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 349);
            textBox1.TabIndex = 10;
            // 
            // Papercut_btn
            // 
            Papercut_btn.Location = new Point(12, 200);
            Papercut_btn.Name = "Papercut_btn";
            Papercut_btn.Size = new Size(107, 41);
            Papercut_btn.TabIndex = 11;
            Papercut_btn.Text = "Papercut";
            Papercut_btn.UseVisualStyleBackColor = true;
            Papercut_btn.Click += Papercut_btn_Click;
            // 
            // Adobe_btn
            // 
            Adobe_btn.Location = new Point(12, 247);
            Adobe_btn.Name = "Adobe_btn";
            Adobe_btn.Size = new Size(107, 36);
            Adobe_btn.TabIndex = 12;
            Adobe_btn.Text = "Adobe";
            Adobe_btn.UseVisualStyleBackColor = true;
            Adobe_btn.Click += Adobe_btn_Click;
            // 
            // Sophos_btn
            // 
            Sophos_btn.Location = new Point(12, 288);
            Sophos_btn.Name = "Sophos_btn";
            Sophos_btn.Size = new Size(107, 36);
            Sophos_btn.TabIndex = 13;
            Sophos_btn.Text = "Sophos";
            Sophos_btn.UseVisualStyleBackColor = true;
            Sophos_btn.Click += Sophos_btn_Click;
            // 
            // Splashtop_btn
            // 
            Splashtop_btn.Location = new Point(12, 330);
            Splashtop_btn.Name = "Splashtop_btn";
            Splashtop_btn.Size = new Size(107, 36);
            Splashtop_btn.TabIndex = 14;
            Splashtop_btn.Text = "Splashtop";
            Splashtop_btn.UseVisualStyleBackColor = true;
            Splashtop_btn.Click += Splashtop_btn_Click;
            // 
            // Cloudflare_btn
            // 
            Cloudflare_btn.Location = new Point(12, 372);
            Cloudflare_btn.Name = "Cloudflare_btn";
            Cloudflare_btn.Size = new Size(107, 36);
            Cloudflare_btn.TabIndex = 15;
            Cloudflare_btn.Text = "CloudFlare";
            Cloudflare_btn.UseVisualStyleBackColor = true;
            Cloudflare_btn.Click += Cloudflare_btn_Click;
            // 
            // Office365_btn
            // 
            Office365_btn.Location = new Point(12, 414);
            Office365_btn.Name = "Office365_btn";
            Office365_btn.Size = new Size(107, 36);
            Office365_btn.TabIndex = 16;
            Office365_btn.Text = "Office 365";
            Office365_btn.UseVisualStyleBackColor = true;
            Office365_btn.Click += Office365_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 510);
            Controls.Add(Office365_btn);
            Controls.Add(Cloudflare_btn);
            Controls.Add(Splashtop_btn);
            Controls.Add(Sophos_btn);
            Controls.Add(Adobe_btn);
            Controls.Add(Papercut_btn);
            Controls.Add(textBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Name = "Form1";
            Text = "ccInstaller";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox1;
        private Button Papercut_btn;
        private Button Adobe_btn;
        private Button Sophos_btn;
        private Button Splashtop_btn;
        private Button Cloudflare_btn;
        private Button Office365_btn;
    }
}
