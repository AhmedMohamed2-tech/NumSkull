namespace NumSkull
{
    partial class AdvancedForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonLn;
        private System.Windows.Forms.Button buttonFactorial;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBasic;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEquals;
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonFactorial = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBasic = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxInput.Location = new System.Drawing.Point(12, 38);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(423, 22);
            this.textBoxInput.TabIndex = 0;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxResult.Location = new System.Drawing.Point(12, 12);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(423, 19);
            this.textBoxResult.TabIndex = 1;
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSin.Location = new System.Drawing.Point(86, 69);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(51, 49);
            this.buttonSin.TabIndex = 2;
            this.buttonSin.Text = "Sin";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.ButtonSin_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCos.Location = new System.Drawing.Point(142, 69);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(50, 49);
            this.buttonCos.TabIndex = 3;
            this.buttonCos.Text = "Cos";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.ButtonCos_Click);
            // 
            // buttonTan
            // 
            this.buttonTan.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTan.Location = new System.Drawing.Point(198, 69);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(50, 49);
            this.buttonTan.TabIndex = 4;
            this.buttonTan.Text = "Tan";
            this.buttonTan.UseVisualStyleBackColor = false;
            this.buttonTan.Click += new System.EventHandler(this.ButtonTan_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLog.Location = new System.Drawing.Point(254, 237);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(50, 49);
            this.buttonLog.TabIndex = 5;
            this.buttonLog.Text = "Log 10";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.ButtonLog_Click);
            // 
            // buttonLn
            // 
            this.buttonLn.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLn.Location = new System.Drawing.Point(254, 181);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(50, 49);
            this.buttonLn.TabIndex = 6;
            this.buttonLn.Text = "Log";
            this.buttonLn.UseVisualStyleBackColor = false;
            this.buttonLn.Click += new System.EventHandler(this.ButtonLn_Click);
            // 
            // buttonFactorial
            // 
            this.buttonFactorial.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFactorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFactorial.Location = new System.Drawing.Point(254, 125);
            this.buttonFactorial.Name = "buttonFactorial";
            this.buttonFactorial.Size = new System.Drawing.Size(50, 49);
            this.buttonFactorial.TabIndex = 8;
            this.buttonFactorial.Text = "!";
            this.buttonFactorial.UseVisualStyleBackColor = false;
            this.buttonFactorial.Click += new System.EventHandler(this.ButtonFactorial_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(142, 293);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 49);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(86, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(142, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(198, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 49);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(86, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 49);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(142, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 49);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(198, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 49);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(86, 125);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 49);
            this.button7.TabIndex = 16;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(142, 125);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 49);
            this.button8.TabIndex = 17;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(198, 125);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 49);
            this.button9.TabIndex = 18;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDot.Location = new System.Drawing.Point(198, 293);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(50, 49);
            this.buttonDot.TabIndex = 19;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClear.Location = new System.Drawing.Point(310, 291);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 49);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonBasic
            // 
            this.buttonBasic.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBasic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBasic.Location = new System.Drawing.Point(86, 291);
            this.buttonBasic.Name = "buttonBasic";
            this.buttonBasic.Size = new System.Drawing.Size(50, 49);
            this.buttonBasic.TabIndex = 21;
            this.buttonBasic.Text = "Basic";
            this.buttonBasic.UseVisualStyleBackColor = false;
            this.buttonBasic.Click += new System.EventHandler(this.ButtonBasic_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(310, 235);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 49);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSubtract.Location = new System.Drawing.Point(310, 179);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(50, 49);
            this.buttonSubtract.TabIndex = 23;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMultiply.Location = new System.Drawing.Point(310, 123);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(50, 49);
            this.buttonMultiply.TabIndex = 24;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDivide.Location = new System.Drawing.Point(310, 69);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(50, 49);
            this.buttonDivide.TabIndex = 25;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEquals.Location = new System.Drawing.Point(254, 291);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(50, 49);
            this.buttonEquals.TabIndex = 26;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPi.Location = new System.Drawing.Point(254, 69);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(50, 49);
            this.buttonPi.TabIndex = 27;
            this.buttonPi.Text = "π";
            this.buttonPi.UseVisualStyleBackColor = false;
            this.buttonPi.Click += new System.EventHandler(this.ButtonPi_Click);
            // 
            // AdvancedForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(447, 346);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBasic);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonFactorial);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxInput);
            this.Name = "AdvancedForm";
            this.Text = "Advanced Functions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}