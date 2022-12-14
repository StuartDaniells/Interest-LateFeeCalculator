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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCusType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dueDatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblNumOfLateGames = new System.Windows.Forms.Label();
            this.btnAddLateGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentDate.Location = new System.Drawing.Point(234, 272);
            this.txtCurrentDate.Margin = new System.Windows.Forms.Padding(1);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(115, 26);
            this.txtCurrentDate.TabIndex = 11;
            this.txtCurrentDate.TabStop = false;
            this.txtCurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDaysLate
            // 
            this.txtDaysLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysLate.Location = new System.Drawing.Point(234, 318);
            this.txtDaysLate.Margin = new System.Windows.Forms.Padding(1);
            this.txtDaysLate.Name = "txtDaysLate";
            this.txtDaysLate.ReadOnly = true;
            this.txtDaysLate.Size = new System.Drawing.Size(115, 26);
            this.txtDaysLate.TabIndex = 12;
            this.txtDaysLate.TabStop = false;
            this.txtDaysLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLateFee
            // 
            this.txtLateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLateFee.Location = new System.Drawing.Point(234, 360);
            this.txtLateFee.Margin = new System.Windows.Forms.Padding(1);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.ReadOnly = true;
            this.txtLateFee.Size = new System.Drawing.Size(115, 26);
            this.txtLateFee.TabIndex = 14;
            this.txtLateFee.TabStop = false;
            this.txtLateFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReturn
            // 
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(60, 416);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(87, 28);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(262, 416);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(1);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 28);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Late Fee: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of Days Late: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Current Date: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "&Due Date: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Library Games:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(54, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 35);
            this.label6.TabIndex = 16;
            this.label6.Text = "$0.77 per day per game";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "&Number of Games: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCusType
            // 
            this.comboBoxCusType.AllowDrop = true;
            this.comboBoxCusType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCusType.FormattingEnabled = true;
            this.comboBoxCusType.Items.AddRange(new object[] {
            "New",
            "Loyal",
            "Junior"});
            this.comboBoxCusType.Location = new System.Drawing.Point(234, 191);
            this.comboBoxCusType.MaxDropDownItems = 3;
            this.comboBoxCusType.Name = "comboBoxCusType";
            this.comboBoxCusType.Size = new System.Drawing.Size(115, 21);
            this.comboBoxCusType.TabIndex = 2;
            this.comboBoxCusType.SelectedIndexChanged += new System.EventHandler(this.ClearTextBox);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(56, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Customer Type:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dueDatePicker1
            // 
            this.dueDatePicker1.Location = new System.Drawing.Point(234, 232);
            this.dueDatePicker1.Margin = new System.Windows.Forms.Padding(1);
            this.dueDatePicker1.Name = "dueDatePicker1";
            this.dueDatePicker1.Size = new System.Drawing.Size(115, 20);
            this.dueDatePicker1.TabIndex = 3;
            this.dueDatePicker1.Value = new System.DateTime(2022, 3, 13, 0, 0, 0, 0);
            this.dueDatePicker1.ValueChanged += new System.EventHandler(this.ClearTextBox);
            // 
            // lblNumOfLateGames
            // 
            this.lblNumOfLateGames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumOfLateGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfLateGames.Location = new System.Drawing.Point(234, 149);
            this.lblNumOfLateGames.Name = "lblNumOfLateGames";
            this.lblNumOfLateGames.Size = new System.Drawing.Size(115, 23);
            this.lblNumOfLateGames.TabIndex = 21;
            // 
            // btnAddLateGames
            // 
            this.btnAddLateGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLateGames.Location = new System.Drawing.Point(125, 104);
            this.btnAddLateGames.Name = "btnAddLateGames";
            this.btnAddLateGames.Size = new System.Drawing.Size(163, 31);
            this.btnAddLateGames.TabIndex = 1;
            this.btnAddLateGames.Text = "Add your late games";
            this.btnAddLateGames.UseVisualStyleBackColor = true;
            this.btnAddLateGames.Click += new System.EventHandler(this.btnAddLateGames_Click);
            // 
            // frmLibrary
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(419, 470);
            this.Controls.Add(this.btnAddLateGames);
            this.Controls.Add(this.lblNumOfLateGames);
            this.Controls.Add(this.dueDatePicker1);
            this.Controls.Add(this.comboBoxCusType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Library";
            this.TextChanged += new System.EventHandler(this.ClearTextBox);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCusType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dueDatePicker1;
        private System.Windows.Forms.Label lblNumOfLateGames;
        private System.Windows.Forms.Button btnAddLateGames;
    }
}