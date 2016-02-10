namespace SoftwareSales
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
            this.groupBoxPakSold = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPakA = new System.Windows.Forms.TextBox();
            this.textBoxPakB = new System.Windows.Forms.TextBox();
            this.textBoxPakC = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPakCtotal = new System.Windows.Forms.TextBox();
            this.textBoxPakBtotal = new System.Windows.Forms.TextBox();
            this.textBoxPakAtotal = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxPakSold.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPakSold
            // 
            this.groupBoxPakSold.Controls.Add(this.textBoxPakC);
            this.groupBoxPakSold.Controls.Add(this.textBoxPakB);
            this.groupBoxPakSold.Controls.Add(this.textBoxPakA);
            this.groupBoxPakSold.Controls.Add(this.label4);
            this.groupBoxPakSold.Controls.Add(this.label3);
            this.groupBoxPakSold.Controls.Add(this.label2);
            this.groupBoxPakSold.Controls.Add(this.label1);
            this.groupBoxPakSold.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPakSold.Name = "groupBoxPakSold";
            this.groupBoxPakSold.Size = new System.Drawing.Size(224, 149);
            this.groupBoxPakSold.TabIndex = 0;
            this.groupBoxPakSold.TabStop = false;
            this.groupBoxPakSold.Text = "Packages Sold";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of packages sold for each package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Package A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Package B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Package C";
            // 
            // textBoxPakA
            // 
            this.textBoxPakA.Location = new System.Drawing.Point(70, 55);
            this.textBoxPakA.Name = "textBoxPakA";
            this.textBoxPakA.Size = new System.Drawing.Size(100, 20);
            this.textBoxPakA.TabIndex = 4;
            // 
            // textBoxPakB
            // 
            this.textBoxPakB.Location = new System.Drawing.Point(70, 81);
            this.textBoxPakB.Name = "textBoxPakB";
            this.textBoxPakB.Size = new System.Drawing.Size(100, 20);
            this.textBoxPakB.TabIndex = 5;
            // 
            // textBoxPakC
            // 
            this.textBoxPakC.Location = new System.Drawing.Point(70, 107);
            this.textBoxPakC.Name = "textBoxPakC";
            this.textBoxPakC.Size = new System.Drawing.Size(100, 20);
            this.textBoxPakC.TabIndex = 1;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(98, 180);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(84, 66);
            this.buttonCalc.TabIndex = 1;
            this.buttonCalc.Text = "Calulate Revenue";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(278, 180);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(84, 66);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(188, 180);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(84, 66);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxTotal);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.textBoxPakCtotal);
            this.groupBox1.Controls.Add(this.textBoxPakBtotal);
            this.groupBox1.Controls.Add(this.textBoxPakAtotal);
            this.groupBox1.Location = new System.Drawing.Point(242, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Revenue Generated";
            // 
            // textBoxPakCtotal
            // 
            this.textBoxPakCtotal.Location = new System.Drawing.Point(73, 74);
            this.textBoxPakCtotal.Name = "textBoxPakCtotal";
            this.textBoxPakCtotal.ReadOnly = true;
            this.textBoxPakCtotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxPakCtotal.TabIndex = 6;
            // 
            // textBoxPakBtotal
            // 
            this.textBoxPakBtotal.Location = new System.Drawing.Point(72, 48);
            this.textBoxPakBtotal.Name = "textBoxPakBtotal";
            this.textBoxPakBtotal.ReadOnly = true;
            this.textBoxPakBtotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxPakBtotal.TabIndex = 11;
            // 
            // textBoxPakAtotal
            // 
            this.textBoxPakAtotal.Location = new System.Drawing.Point(73, 22);
            this.textBoxPakAtotal.Name = "textBoxPakAtotal";
            this.textBoxPakAtotal.ReadOnly = true;
            this.textBoxPakAtotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxPakAtotal.TabIndex = 10;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(73, 104);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 12;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(23, 110);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Package C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Package B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Package A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.groupBoxPakSold);
            this.Name = "Form1";
            this.Text = "Software Sales";
            this.groupBoxPakSold.ResumeLayout(false);
            this.groupBoxPakSold.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPakSold;
        private System.Windows.Forms.TextBox textBoxPakA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPakC;
        private System.Windows.Forms.TextBox textBoxPakB;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxPakCtotal;
        private System.Windows.Forms.TextBox textBoxPakBtotal;
        private System.Windows.Forms.TextBox textBoxPakAtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

