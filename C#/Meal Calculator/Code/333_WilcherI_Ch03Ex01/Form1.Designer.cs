namespace _333_WilcherI_Ch03Ex01
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
            this.foodChargeLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.overallTotalLabel = new System.Windows.Forms.Label();
            this.foodChargeTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.overallTotalOutput = new System.Windows.Forms.Label();
            this.tipOutput = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.overallOrdersOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.averageTotalOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // foodChargeLabel
            // 
            this.foodChargeLabel.AutoSize = true;
            this.foodChargeLabel.Location = new System.Drawing.Point(16, 56);
            this.foodChargeLabel.Name = "foodChargeLabel";
            this.foodChargeLabel.Size = new System.Drawing.Size(68, 13);
            this.foodChargeLabel.TabIndex = 0;
            this.foodChargeLabel.Text = "Food Charge";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(16, 98);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(54, 13);
            this.salesTaxLabel.TabIndex = 1;
            this.salesTaxLabel.Text = "Sales Tax";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(16, 139);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(22, 13);
            this.tipLabel.TabIndex = 2;
            this.tipLabel.Text = "Tip";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(16, 179);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total";
            // 
            // overallTotalLabel
            // 
            this.overallTotalLabel.AutoSize = true;
            this.overallTotalLabel.Location = new System.Drawing.Point(16, 228);
            this.overallTotalLabel.Name = "overallTotalLabel";
            this.overallTotalLabel.Size = new System.Drawing.Size(67, 13);
            this.overallTotalLabel.TabIndex = 4;
            this.overallTotalLabel.Text = "Overall Total";
            // 
            // foodChargeTextBox
            // 
            this.foodChargeTextBox.Location = new System.Drawing.Point(102, 56);
            this.foodChargeTextBox.Name = "foodChargeTextBox";
            this.foodChargeTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodChargeTextBox.TabIndex = 5;
            // 
            // salesTaxOutput
            // 
            this.salesTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesTaxOutput.Location = new System.Drawing.Point(102, 98);
            this.salesTaxOutput.Name = "salesTaxOutput";
            this.salesTaxOutput.Size = new System.Drawing.Size(100, 23);
            this.salesTaxOutput.TabIndex = 6;
            this.salesTaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalOutput.Location = new System.Drawing.Point(102, 174);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOutput.TabIndex = 7;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overallTotalOutput
            // 
            this.overallTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overallTotalOutput.Location = new System.Drawing.Point(102, 223);
            this.overallTotalOutput.Name = "overallTotalOutput";
            this.overallTotalOutput.Size = new System.Drawing.Size(100, 23);
            this.overallTotalOutput.TabIndex = 8;
            this.overallTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipOutput
            // 
            this.tipOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tipOutput.Location = new System.Drawing.Point(102, 134);
            this.tipOutput.Name = "tipOutput";
            this.tipOutput.Size = new System.Drawing.Size(100, 23);
            this.tipOutput.TabIndex = 9;
            this.tipOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(218, 110);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(218, 173);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(218, 237);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_333_WilcherI_Ch03Ex01.Properties.Resources.ForkKnife;
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(218, 204);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 14;
            this.clearAllButton.Text = "Clear &All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Overall Orders";
            // 
            // overallOrdersOutput
            // 
            this.overallOrdersOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.overallOrdersOutput.Location = new System.Drawing.Point(102, 18);
            this.overallOrdersOutput.Name = "overallOrdersOutput";
            this.overallOrdersOutput.Size = new System.Drawing.Size(37, 23);
            this.overallOrdersOutput.TabIndex = 16;
            this.overallOrdersOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Average";
            // 
            // averageTotalOutput
            // 
            this.averageTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageTotalOutput.Location = new System.Drawing.Point(102, 261);
            this.averageTotalOutput.Name = "averageTotalOutput";
            this.averageTotalOutput.Size = new System.Drawing.Size(100, 23);
            this.averageTotalOutput.TabIndex = 18;
            this.averageTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(305, 300);
            this.Controls.Add(this.averageTotalOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.overallOrdersOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.tipOutput);
            this.Controls.Add(this.overallTotalOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.salesTaxOutput);
            this.Controls.Add(this.foodChargeTextBox);
            this.Controls.Add(this.overallTotalLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.foodChargeLabel);
            this.Name = "Form1";
            this.Text = "Meal Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodChargeLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label overallTotalLabel;
        private System.Windows.Forms.TextBox foodChargeTextBox;
        private System.Windows.Forms.Label salesTaxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label overallTotalOutput;
        private System.Windows.Forms.Label tipOutput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label overallOrdersOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label averageTotalOutput;
    }
}

