namespace HeadFirstChapter4Ex1
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
            this.startingMilageAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.endingMilageAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.amountOwedDisplay = new System.Windows.Forms.Label();
            this.calculateAmountBtn = new System.Windows.Forms.Button();
            this.showMilesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startingMilageAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingMilageAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Milage:";
            // 
            // startingMilageAmount
            // 
            this.startingMilageAmount.Location = new System.Drawing.Point(100, 13);
            this.startingMilageAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.startingMilageAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startingMilageAmount.Name = "startingMilageAmount";
            this.startingMilageAmount.Size = new System.Drawing.Size(120, 20);
            this.startingMilageAmount.TabIndex = 1;
            this.startingMilageAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ending Milage: ";
            // 
            // endingMilageAmount
            // 
            this.endingMilageAmount.Location = new System.Drawing.Point(100, 39);
            this.endingMilageAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.endingMilageAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endingMilageAmount.Name = "endingMilageAmount";
            this.endingMilageAmount.Size = new System.Drawing.Size(120, 20);
            this.endingMilageAmount.TabIndex = 3;
            this.endingMilageAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Owed:";
            // 
            // amountOwedDisplay
            // 
            this.amountOwedDisplay.AutoSize = true;
            this.amountOwedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOwedDisplay.Location = new System.Drawing.Point(100, 66);
            this.amountOwedDisplay.Name = "amountOwedDisplay";
            this.amountOwedDisplay.Size = new System.Drawing.Size(54, 20);
            this.amountOwedDisplay.TabIndex = 5;
            this.amountOwedDisplay.Text = "$0.00";
            // 
            // calculateAmountBtn
            // 
            this.calculateAmountBtn.Location = new System.Drawing.Point(16, 96);
            this.calculateAmountBtn.Name = "calculateAmountBtn";
            this.calculateAmountBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateAmountBtn.TabIndex = 6;
            this.calculateAmountBtn.Text = "Calculate";
            this.calculateAmountBtn.UseVisualStyleBackColor = true;
            this.calculateAmountBtn.Click += new System.EventHandler(this.calculateAmountBtn_Click);
            // 
            // showMilesBtn
            // 
            this.showMilesBtn.Location = new System.Drawing.Point(104, 96);
            this.showMilesBtn.Name = "showMilesBtn";
            this.showMilesBtn.Size = new System.Drawing.Size(75, 23);
            this.showMilesBtn.TabIndex = 7;
            this.showMilesBtn.Text = "Display Miles";
            this.showMilesBtn.UseVisualStyleBackColor = true;
            this.showMilesBtn.Click += new System.EventHandler(this.showMilesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 122);
            this.Controls.Add(this.showMilesBtn);
            this.Controls.Add(this.calculateAmountBtn);
            this.Controls.Add(this.amountOwedDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endingMilageAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startingMilageAmount);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Milage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.startingMilageAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingMilageAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown startingMilageAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown endingMilageAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label amountOwedDisplay;
        private System.Windows.Forms.Button calculateAmountBtn;
        private System.Windows.Forms.Button showMilesBtn;
    }
}

