namespace Hotel_room_booking_system
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.roomtype = new System.Windows.Forms.GroupBox();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoHight = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bookingdetails = new System.Windows.Forms.ListBox();
            this.roomtype.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "personal information ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guest Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of nights";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Guest";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(232, 82);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(311, 26);
            this.txtname.TabIndex = 5;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(232, 134);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(311, 26);
            this.txtage.TabIndex = 6;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(232, 185);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(311, 26);
            this.txtNights.TabIndex = 7;
            // 
            // txtGuest
            // 
            this.txtGuest.Location = new System.Drawing.Point(232, 251);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Size = new System.Drawing.Size(311, 26);
            this.txtGuest.TabIndex = 8;
            // 
            // roomtype
            // 
            this.roomtype.Controls.Add(this.rdoHight);
            this.roomtype.Controls.Add(this.rdoNormal);
            this.roomtype.Controls.Add(this.rdoStandard);
            this.roomtype.Location = new System.Drawing.Point(37, 328);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(534, 110);
            this.roomtype.TabIndex = 9;
            this.roomtype.TabStop = false;
            this.roomtype.Text = "Room Type";
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Location = new System.Drawing.Point(34, 39);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(97, 24);
            this.rdoStandard.TabIndex = 0;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(195, 43);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(82, 24);
            this.rdoNormal.TabIndex = 1;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoHight
            // 
            this.rdoHight.AutoSize = true;
            this.rdoHight.Location = new System.Drawing.Point(380, 43);
            this.rdoHight.Name = "rdoHight";
            this.rdoHight.Size = new System.Drawing.Size(72, 24);
            this.rdoHight.TabIndex = 2;
            this.rdoHight.TabStop = true;
            this.rdoHight.Text = "Hight";
            this.rdoHight.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBreakfast);
            this.groupBox1.Location = new System.Drawing.Point(37, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 91);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aditional Options";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(34, 41);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(254, 24);
            this.chkBreakfast.TabIndex = 0;
            this.chkBreakfast.Text = "Breakfast(10 per Guest nights)";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(95, 596);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 42);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(310, 596);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 42);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(490, 596);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 42);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bookingdetails
            // 
            this.bookingdetails.FormattingEnabled = true;
            this.bookingdetails.ItemHeight = 20;
            this.bookingdetails.Location = new System.Drawing.Point(588, 24);
            this.bookingdetails.Name = "bookingdetails";
            this.bookingdetails.Size = new System.Drawing.Size(414, 564);
            this.bookingdetails.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 671);
            this.Controls.Add(this.bookingdetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.txtGuest);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.roomtype.ResumeLayout(false);
            this.roomtype.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtGuest;
        private System.Windows.Forms.GroupBox roomtype;
        private System.Windows.Forms.RadioButton rdoHight;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox bookingdetails;
    }
}

