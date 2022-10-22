namespace StuartsLateFeeCalculator
{
    partial class frmLibrary
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
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.txtDaysLate = new System.Windows.Forms.TextBox();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDueDate
            // 
            this.txtDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDate.Location = new System.Drawing.Point(629, 166);
            this.txtDueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(273, 53);
            this.txtDueDate.TabIndex = 1;
            this.txtDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentDate.Location = new System.Drawing.Point(629, 267);
            this.txtCurrentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(273, 53);
            this.txtCurrentDate.TabIndex = 2;
            this.txtCurrentDate.TabStop = false;
            this.txtCurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDaysLate
            // 
            this.txtDaysLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysLate.Location = new System.Drawing.Point(629, 367);
            this.txtDaysLate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDaysLate.Name = "txtDaysLate";
            this.txtDaysLate.ReadOnly = true;
            this.txtDaysLate.Size = new System.Drawing.Size(273, 53);
            this.txtDaysLate.TabIndex = 12;
            this.txtDaysLate.TabStop = false;
            this.txtDaysLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLateFee
            // 
            this.txtLateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLateFee.Location = new System.Drawing.Point(629, 476);
            this.txtLateFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.ReadOnly = true;
            this.txtLateFee.Size = new System.Drawing.Size(273, 53);
            this.txtLateFee.TabIndex = 14;
            this.txtLateFee.TabStop = false;
            this.txtLateFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReturn
            // 
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(253, 598);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(232, 67);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(655, 598);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(232, 67);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 46);
            this.label5.TabIndex = 15;
            this.label5.Text = "Late Fee: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 46);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of Days Late: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "Current Date: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "&Due Date: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(945, 84);
            this.label1.TabIndex = 7;
            this.label1.Text = "Library Games- $0.77 per day";
            // 
            // frmLibrary
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(1118, 734);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.txtCurrentDate);
            this.Controls.Add(this.txtDaysLate);
            this.Controls.Add(this.txtLateFee);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.TextBox txtDaysLate;
        private System.Windows.Forms.TextBox txtLateFee;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}