namespace HeadFirstChapter4Ex2
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
            this.lloydBtn = new System.Windows.Forms.Button();
            this.lucindaBtn = new System.Windows.Forms.Button();
            this.swapBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lloydBtn
            // 
            this.lloydBtn.Location = new System.Drawing.Point(13, 13);
            this.lloydBtn.Name = "lloydBtn";
            this.lloydBtn.Size = new System.Drawing.Size(75, 23);
            this.lloydBtn.TabIndex = 0;
            this.lloydBtn.Text = "Lloyd";
            this.lloydBtn.UseVisualStyleBackColor = true;
            this.lloydBtn.Click += new System.EventHandler(this.lloydBtn_Click);
            // 
            // lucindaBtn
            // 
            this.lucindaBtn.Location = new System.Drawing.Point(13, 52);
            this.lucindaBtn.Name = "lucindaBtn";
            this.lucindaBtn.Size = new System.Drawing.Size(75, 23);
            this.lucindaBtn.TabIndex = 1;
            this.lucindaBtn.Text = "Lucinda";
            this.lucindaBtn.UseVisualStyleBackColor = true;
            this.lucindaBtn.Click += new System.EventHandler(this.lucindaBtn_Click);
            // 
            // swapBtn
            // 
            this.swapBtn.Location = new System.Drawing.Point(13, 95);
            this.swapBtn.Name = "swapBtn";
            this.swapBtn.Size = new System.Drawing.Size(75, 23);
            this.swapBtn.TabIndex = 2;
            this.swapBtn.Text = "Swap!";
            this.swapBtn.UseVisualStyleBackColor = true;
            this.swapBtn.Click += new System.EventHandler(this.swapBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 147);
            this.Controls.Add(this.swapBtn);
            this.Controls.Add(this.lucindaBtn);
            this.Controls.Add(this.lloydBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lloydBtn;
        private System.Windows.Forms.Button lucindaBtn;
        private System.Windows.Forms.Button swapBtn;
    }
}

