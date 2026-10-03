namespace Test_score_average
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.btncalcualate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txttest1 = new System.Windows.Forms.TextBox();
            this.txttest2 = new System.Windows.Forms.TextBox();
            this.txttest3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "test score #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "test score #2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "test score #3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average";
            // 
            // lblaverage
            // 
            this.lblaverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblaverage.Location = new System.Drawing.Point(190, 218);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(216, 59);
            this.lblaverage.TabIndex = 4;
            // 
            // btncalcualate
            // 
            this.btncalcualate.Location = new System.Drawing.Point(131, 325);
            this.btncalcualate.Name = "btncalcualate";
            this.btncalcualate.Size = new System.Drawing.Size(196, 94);
            this.btncalcualate.TabIndex = 5;
            this.btncalcualate.Text = "calcualate average";
            this.btncalcualate.UseVisualStyleBackColor = true;
            this.btncalcualate.Click += new System.EventHandler(this.btncalcualate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(352, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 48);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txttest1
            // 
            this.txttest1.Location = new System.Drawing.Point(175, 53);
            this.txttest1.Name = "txttest1";
            this.txttest1.Size = new System.Drawing.Size(295, 35);
            this.txttest1.TabIndex = 8;
            // 
            // txttest2
            // 
            this.txttest2.Location = new System.Drawing.Point(175, 112);
            this.txttest2.Name = "txttest2";
            this.txttest2.Size = new System.Drawing.Size(295, 35);
            this.txttest2.TabIndex = 9;
            // 
            // txttest3
            // 
            this.txttest3.Location = new System.Drawing.Point(175, 167);
            this.txttest3.Name = "txttest3";
            this.txttest3.Size = new System.Drawing.Size(295, 35);
            this.txttest3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 652);
            this.Controls.Add(this.txttest3);
            this.Controls.Add(this.txttest2);
            this.Controls.Add(this.txttest1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btncalcualate);
            this.Controls.Add(this.lblaverage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Button btncalcualate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txttest1;
        private System.Windows.Forms.TextBox txttest2;
        private System.Windows.Forms.TextBox txttest3;
    }
}

