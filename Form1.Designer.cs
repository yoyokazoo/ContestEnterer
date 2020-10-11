namespace ContestEnterer
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
            this.btn_open_browser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_open_browser
            // 
            this.btn_open_browser.Location = new System.Drawing.Point(12, 12);
            this.btn_open_browser.Name = "btn_open_browser";
            this.btn_open_browser.Size = new System.Drawing.Size(270, 80);
            this.btn_open_browser.TabIndex = 0;
            this.btn_open_browser.Text = "Open Chrome";
            this.btn_open_browser.UseVisualStyleBackColor = true;
            this.btn_open_browser.Click += new System.EventHandler(this.btn_open_browser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 691);
            this.Controls.Add(this.btn_open_browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_open_browser;
    }
}

