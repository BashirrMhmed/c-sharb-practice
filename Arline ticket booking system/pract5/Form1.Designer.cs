namespace pract5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpassengername = new System.Windows.Forms.TextBox();
            this.txtpassengerage = new System.Windows.Forms.TextBox();
            this.txtnumberoftikets = new System.Windows.Forms.TextBox();
            this.txtbaggageweight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.rdoNormalClass = new System.Windows.Forms.RadioButton();
            this.rdoFirstClass = new System.Windows.Forms.RadioButton();
            this.checktravelinsurance = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bntClear = new System.Windows.Forms.Button();
            this.chkTravelInsurance = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "passenger name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "passenger age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "number of tikets:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "baggage weight(kg):";
            // 
            // txtpassengername
            // 
            this.txtpassengername.Location = new System.Drawing.Point(216, 37);
            this.txtpassengername.Name = "txtpassengername";
            this.txtpassengername.Size = new System.Drawing.Size(307, 30);
            this.txtpassengername.TabIndex = 5;
            // 
            // txtpassengerage
            // 
            this.txtpassengerage.Location = new System.Drawing.Point(216, 84);
            this.txtpassengerage.Name = "txtpassengerage";
            this.txtpassengerage.Size = new System.Drawing.Size(307, 30);
            this.txtpassengerage.TabIndex = 6;
            // 
            // txtnumberoftikets
            // 
            this.txtnumberoftikets.Location = new System.Drawing.Point(216, 137);
            this.txtnumberoftikets.Name = "txtnumberoftikets";
            this.txtnumberoftikets.Size = new System.Drawing.Size(307, 30);
            this.txtnumberoftikets.TabIndex = 7;
            // 
            // txtbaggageweight
            // 
            this.txtbaggageweight.Location = new System.Drawing.Point(216, 195);
            this.txtbaggageweight.Name = "txtbaggageweight";
            this.txtbaggageweight.Size = new System.Drawing.Size(307, 30);
            this.txtbaggageweight.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBusinessClass);
            this.groupBox1.Controls.Add(this.rdoNormalClass);
            this.groupBox1.Controls.Add(this.rdoFirstClass);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 79);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Travel class";
            // 
            // rdoBusinessClass
            // 
            this.rdoBusinessClass.AutoSize = true;
            this.rdoBusinessClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBusinessClass.Location = new System.Drawing.Point(387, 27);
            this.rdoBusinessClass.Name = "rdoBusinessClass";
            this.rdoBusinessClass.Size = new System.Drawing.Size(153, 24);
            this.rdoBusinessClass.TabIndex = 2;
            this.rdoBusinessClass.TabStop = true;
            this.rdoBusinessClass.Text = "Business class";
            this.rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // rdoNormalClass
            // 
            this.rdoNormalClass.AutoSize = true;
            this.rdoNormalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormalClass.Location = new System.Drawing.Point(197, 27);
            this.rdoNormalClass.Name = "rdoNormalClass";
            this.rdoNormalClass.Size = new System.Drawing.Size(136, 24);
            this.rdoNormalClass.TabIndex = 1;
            this.rdoNormalClass.TabStop = true;
            this.rdoNormalClass.Text = "Normal class";
            this.rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // rdoFirstClass
            // 
            this.rdoFirstClass.AutoSize = true;
            this.rdoFirstClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFirstClass.Location = new System.Drawing.Point(7, 27);
            this.rdoFirstClass.Name = "rdoFirstClass";
            this.rdoFirstClass.Size = new System.Drawing.Size(111, 24);
            this.rdoFirstClass.TabIndex = 0;
            this.rdoFirstClass.TabStop = true;
            this.rdoFirstClass.Text = "first class";
            this.rdoFirstClass.UseVisualStyleBackColor = true;
            // 
            // checktravelinsurance
            // 
            this.checktravelinsurance.AutoSize = true;
            this.checktravelinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checktravelinsurance.Location = new System.Drawing.Point(35, 29);
            this.checktravelinsurance.Name = "checktravelinsurance";
            this.checktravelinsurance.Size = new System.Drawing.Size(363, 26);
            this.checktravelinsurance.TabIndex = 10;
            this.checktravelinsurance.Text = "Add Travel insurance($25 per ticket)";
            this.checktravelinsurance.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checktravelinsurance);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 86);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional options";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtbaggageweight);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtnumberoftikets);
            this.groupBox3.Controls.Add(this.txtpassengername);
            this.groupBox3.Controls.Add(this.txtpassengerage);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 271);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "personal information";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(47, 531);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(128, 54);
            this.btncalculate.TabIndex = 13;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(408, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 54);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(220, 531);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(128, 54);
            this.bntClear.TabIndex = 15;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // chkTravelInsurance
            // 
            this.chkTravelInsurance.FormattingEnabled = true;
            this.chkTravelInsurance.ItemHeight = 20;
            this.chkTravelInsurance.Location = new System.Drawing.Point(625, 13);
            this.chkTravelInsurance.Name = "chkTravelInsurance";
            this.chkTravelInsurance.Size = new System.Drawing.Size(319, 564);
            this.chkTravelInsurance.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 632);
            this.Controls.Add(this.chkTravelInsurance);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpassengername;
        private System.Windows.Forms.TextBox txtpassengerage;
        private System.Windows.Forms.TextBox txtnumberoftikets;
        private System.Windows.Forms.TextBox txtbaggageweight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBusinessClass;
        private System.Windows.Forms.RadioButton rdoNormalClass;
        private System.Windows.Forms.RadioButton rdoFirstClass;
        private System.Windows.Forms.CheckBox checktravelinsurance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.ListBox chkTravelInsurance;
    }
}

