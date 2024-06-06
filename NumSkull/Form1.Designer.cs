using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSkull
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxCurrentInput;
        private System.Windows.Forms.TextBox TxtOperation;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonSquareRoot;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonAdvanced;
        private System.Windows.Forms.Button buttonPi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxCurrentInput = new System.Windows.Forms.TextBox();
            this.TxtOperation = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonAdvanced = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.ColumnOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCurrentInput
            // 
            this.textBoxCurrentInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCurrentInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentInput.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxCurrentInput.Location = new System.Drawing.Point(12, 40);
            this.textBoxCurrentInput.Name = "textBoxCurrentInput";
            this.textBoxCurrentInput.Size = new System.Drawing.Size(218, 22);
            this.textBoxCurrentInput.TabIndex = 0;
            // 
            // TxtOperation
            // 
            this.TxtOperation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOperation.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtOperation.Location = new System.Drawing.Point(12, 14);
            this.TxtOperation.Name = "TxtOperation";
            this.TxtOperation.ReadOnly = true;
            this.TxtOperation.Size = new System.Drawing.Size(218, 19);
            this.TxtOperation.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(180, 243);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubtract.Location = new System.Drawing.Point(180, 186);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(50, 50);
            this.buttonSubtract.TabIndex = 4;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMultiply.Location = new System.Drawing.Point(180, 130);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(50, 50);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDivide.Location = new System.Drawing.Point(180, 75);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(50, 50);
            this.buttonDivide.TabIndex = 6;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquareRoot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSquareRoot.Location = new System.Drawing.Point(124, 75);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(50, 50);
            this.buttonSquareRoot.TabIndex = 7;
            this.buttonSquareRoot.Text = "√";
            this.buttonSquareRoot.UseVisualStyleBackColor = false;
            this.buttonSquareRoot.Click += new System.EventHandler(this.ButtonSquareRoot_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEntry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearEntry.Location = new System.Drawing.Point(12, 75);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(50, 50);
            this.buttonClearEntry.TabIndex = 14;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.ButtonClearEntry_Click);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOperation});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHistory.Location = new System.Drawing.Point(236, 14);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHistory.Size = new System.Drawing.Size(295, 335);
            this.dataGridViewHistory.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(68, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(124, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(68, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 17;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(124, 187);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 18;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 130);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 19;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(68, 130);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 20;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(124, 130);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 21;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(68, 299);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 50);
            this.button0.TabIndex = 22;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDot.Location = new System.Drawing.Point(124, 299);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(50, 50);
            this.buttonDot.TabIndex = 24;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEquals.Location = new System.Drawing.Point(180, 299);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(50, 50);
            this.buttonEquals.TabIndex = 12;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdvanced.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdvanced.Location = new System.Drawing.Point(12, 299);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(50, 50);
            this.buttonAdvanced.TabIndex = 26;
            this.buttonAdvanced.Text = "Adv";
            this.buttonAdvanced.UseVisualStyleBackColor = false;
            this.buttonAdvanced.Click += new System.EventHandler(this.ButtonAdvanced_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPi.Location = new System.Drawing.Point(68, 75);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(50, 50);
            this.buttonPi.TabIndex = 25;
            this.buttonPi.Text = "π";
            this.buttonPi.UseVisualStyleBackColor = false;
            this.buttonPi.Click += new System.EventHandler(this.ButtonPi_Click);
            // 
            // ColumnOperation
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnOperation.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnOperation.HeaderText = "Operation";
            this.ColumnOperation.Name = "ColumnOperation";
            this.ColumnOperation.Width = 250;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(530, 355);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonAdvanced);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.dataGridViewHistory);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.TxtOperation);
            this.Controls.Add(this.textBoxCurrentInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Num Skull";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOperation;
    }
}
