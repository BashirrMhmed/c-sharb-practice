namespace LabAssignment2
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
            this.lblNumberofpackage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumofPackage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SoftwaresalesResults = new System.Windows.Forms.ListBox();
            this.txxtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumberofpackage
            // 
            this.lblNumberofpackage.AutoSize = true;
            this.lblNumberofpackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofpackage.Location = new System.Drawing.Point(26, 79);
            this.lblNumberofpackage.Name = "lblNumberofpackage";
            this.lblNumberofpackage.Size = new System.Drawing.Size(199, 22);
            this.lblNumberofpackage.TabIndex = 0;
            this.lblNumberofpackage.Text = "Number of packages:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "price per package";
            // 
            // txtNumofPackage
            // 
            this.txtNumofPackage.Location = new System.Drawing.Point(259, 79);
            this.txtNumofPackage.Name = "txtNumofPackage";
            this.txtNumofPackage.Size = new System.Drawing.Size(217, 26);
            this.txtNumofPackage.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculate.Location = new System.Drawing.Point(30, 222);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 44);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 44);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(321, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SoftwaresalesResults
            // 
            this.SoftwaresalesResults.FormattingEnabled = true;
            this.SoftwaresalesResults.ItemHeight = 20;
            this.SoftwaresalesResults.Location = new System.Drawing.Point(543, 12);
            this.SoftwaresalesResults.Name = "SoftwaresalesResults";
            this.SoftwaresalesResults.Size = new System.Drawing.Size(358, 444);
            this.SoftwaresalesResults.TabIndex = 8;
            // 
            // txxtPrice
            // 
            this.txxtPrice.Location = new System.Drawing.Point(259, 134);
            this.txxtPrice.Name = "txxtPrice";
            this.txxtPrice.Size = new System.Drawing.Size(206, 26);
            this.txxtPrice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 551);
            this.Controls.Add(this.txxtPrice);
            this.Controls.Add(this.SoftwaresalesResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblNumberofpackage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumofPackage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberofpackage;
        private System.Windows.Forms.TextBox txtNumofPackage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox SoftwaresalesResults;
        private System.Windows.Forms.TextBox txxtPrice;
    }
}

