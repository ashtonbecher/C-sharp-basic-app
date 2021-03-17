namespace C01
{
    partial class SimpleCalcFrm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.op1Lbl = new System.Windows.Forms.Label();
            this.op2Lbl = new System.Windows.Forms.Label();
            this.divideLine = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.myNameLbl = new System.Windows.Forms.Label();
            this.keysLbl = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.Label();
            this.operationsLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.subtractBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.functionsLbl = new System.Windows.Forms.Label();
            this.minBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.op1TxtBox = new System.Windows.Forms.NumericUpDown();
            this.op2TxtBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.op1TxtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.op2TxtBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Purple;
            this.titleLbl.Location = new System.Drawing.Point(9, 7);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(178, 17);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Ashton Becher\'s Calculator";
            // 
            // op1Lbl
            // 
            this.op1Lbl.AutoSize = true;
            this.op1Lbl.Location = new System.Drawing.Point(10, 63);
            this.op1Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.op1Lbl.Name = "op1Lbl";
            this.op1Lbl.Size = new System.Drawing.Size(91, 13);
            this.op1Lbl.TabIndex = 1;
            this.op1Lbl.Text = "Enter Operand 1: ";
            // 
            // op2Lbl
            // 
            this.op2Lbl.AutoSize = true;
            this.op2Lbl.Location = new System.Drawing.Point(10, 97);
            this.op2Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.op2Lbl.Name = "op2Lbl";
            this.op2Lbl.Size = new System.Drawing.Size(91, 13);
            this.op2Lbl.TabIndex = 2;
            this.op2Lbl.Text = "Enter Operand 2: ";
            // 
            // divideLine
            // 
            this.divideLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divideLine.Location = new System.Drawing.Point(56, 130);
            this.divideLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.divideLine.Name = "divideLine";
            this.divideLine.Size = new System.Drawing.Size(125, 2);
            this.divideLine.TabIndex = 3;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(42, 158);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(37, 13);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "Result";
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Location = new System.Drawing.Point(106, 156);
            this.resultTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultTxtBox.MaxLength = 5;
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.ReadOnly = true;
            this.resultTxtBox.Size = new System.Drawing.Size(76, 20);
            this.resultTxtBox.TabIndex = 12;
            // 
            // myNameLbl
            // 
            this.myNameLbl.AutoSize = true;
            this.myNameLbl.Location = new System.Drawing.Point(10, 232);
            this.myNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myNameLbl.Name = "myNameLbl";
            this.myNameLbl.Size = new System.Drawing.Size(77, 13);
            this.myNameLbl.TabIndex = 6;
            this.myNameLbl.Text = "Ashton Becher";
            // 
            // keysLbl
            // 
            this.keysLbl.AutoSize = true;
            this.keysLbl.Location = new System.Drawing.Point(223, 25);
            this.keysLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keysLbl.Name = "keysLbl";
            this.keysLbl.Size = new System.Drawing.Size(30, 13);
            this.keysLbl.TabIndex = 7;
            this.keysLbl.Text = "Keys";
            // 
            // groupBox
            // 
            this.groupBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groupBox.Location = new System.Drawing.Point(217, 39);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(142, 174);
            this.groupBox.TabIndex = 8;
            // 
            // operationsLbl
            // 
            this.operationsLbl.AutoSize = true;
            this.operationsLbl.Location = new System.Drawing.Point(223, 40);
            this.operationsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.operationsLbl.Name = "operationsLbl";
            this.operationsLbl.Size = new System.Drawing.Size(58, 13);
            this.operationsLbl.TabIndex = 9;
            this.operationsLbl.Text = "Operations";
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.Location = new System.Drawing.Point(225, 58);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(40, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // subtractBtn
            // 
            this.subtractBtn.AutoSize = true;
            this.subtractBtn.Location = new System.Drawing.Point(292, 60);
            this.subtractBtn.Margin = new System.Windows.Forms.Padding(2);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(41, 23);
            this.subtractBtn.TabIndex = 4;
            this.subtractBtn.Text = "-";
            this.subtractBtn.UseVisualStyleBackColor = true;
            this.subtractBtn.Click += new System.EventHandler(this.SubtractBtn_Click);
            // 
            // multBtn
            // 
            this.multBtn.AutoSize = true;
            this.multBtn.Location = new System.Drawing.Point(225, 93);
            this.multBtn.Margin = new System.Windows.Forms.Padding(2);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(40, 23);
            this.multBtn.TabIndex = 5;
            this.multBtn.Text = "*";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.MultBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.AutoSize = true;
            this.divideBtn.Location = new System.Drawing.Point(292, 93);
            this.divideBtn.Margin = new System.Windows.Forms.Padding(2);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(41, 23);
            this.divideBtn.TabIndex = 6;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // functionsLbl
            // 
            this.functionsLbl.AutoSize = true;
            this.functionsLbl.Location = new System.Drawing.Point(223, 130);
            this.functionsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.functionsLbl.Name = "functionsLbl";
            this.functionsLbl.Size = new System.Drawing.Size(53, 13);
            this.functionsLbl.TabIndex = 14;
            this.functionsLbl.Text = "Functions";
            // 
            // minBtn
            // 
            this.minBtn.AutoSize = true;
            this.minBtn.Location = new System.Drawing.Point(225, 154);
            this.minBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(40, 23);
            this.minBtn.TabIndex = 7;
            this.minBtn.Text = "Min";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.AutoSize = true;
            this.maxBtn.Location = new System.Drawing.Point(292, 154);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(2);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(41, 23);
            this.maxBtn.TabIndex = 8;
            this.maxBtn.Text = "Max";
            this.maxBtn.UseVisualStyleBackColor = true;
            this.maxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.AutoSize = true;
            this.Sqrt.Location = new System.Drawing.Point(225, 177);
            this.Sqrt.Margin = new System.Windows.Forms.Padding(2);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(40, 23);
            this.Sqrt.TabIndex = 9;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.Location = new System.Drawing.Point(225, 228);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(56, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(292, 228);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(56, 23);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // op1TxtBox
            // 
            this.op1TxtBox.Location = new System.Drawing.Point(105, 60);
            this.op1TxtBox.Name = "op1TxtBox";
            this.op1TxtBox.Size = new System.Drawing.Size(77, 20);
            this.op1TxtBox.TabIndex = 15;
            // 
            // op2TxtBox
            // 
            this.op2TxtBox.Location = new System.Drawing.Point(105, 95);
            this.op2TxtBox.Name = "op2TxtBox";
            this.op2TxtBox.Size = new System.Drawing.Size(77, 20);
            this.op2TxtBox.TabIndex = 16;
            // 
            // simpleCalcFrm
            // 
            this.AcceptButton = this.clearBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(385, 271);
            this.ControlBox = false;
            this.Controls.Add(this.op2TxtBox);
            this.Controls.Add(this.op1TxtBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.maxBtn);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.functionsLbl);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.multBtn);
            this.Controls.Add(this.subtractBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.operationsLbl);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.keysLbl);
            this.Controls.Add(this.myNameLbl);
            this.Controls.Add(this.resultTxtBox);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.divideLine);
            this.Controls.Add(this.op2Lbl);
            this.Controls.Add(this.op1Lbl);
            this.Controls.Add(this.titleLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "simpleCalcFrm";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.SimpleCalcFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.op1TxtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.op2TxtBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label op1Lbl;
        private System.Windows.Forms.Label op2Lbl;
        private System.Windows.Forms.Label divideLine;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.TextBox resultTxtBox;
        private System.Windows.Forms.Label myNameLbl;
        private System.Windows.Forms.Label keysLbl;
        private System.Windows.Forms.Label groupBox;
        private System.Windows.Forms.Label operationsLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subtractBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Label functionsLbl;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.NumericUpDown op1TxtBox;
        private System.Windows.Forms.NumericUpDown op2TxtBox;
    }
}

