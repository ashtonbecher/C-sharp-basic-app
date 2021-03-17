
namespace C01
{
    partial class ErrorBox
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
            this.btnErrorOk = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnErrorOk
            // 
            this.btnErrorOk.Location = new System.Drawing.Point(119, 60);
            this.btnErrorOk.Name = "btnErrorOk";
            this.btnErrorOk.Size = new System.Drawing.Size(75, 23);
            this.btnErrorOk.TabIndex = 0;
            this.btnErrorOk.Text = "OK";
            this.btnErrorOk.UseVisualStyleBackColor = true;
            this.btnErrorOk.Click += new System.EventHandler(this.BtnErrorOk_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(21, 25);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(270, 13);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Please enter a non-zero number for the second operand";
            // 
            // errorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 95);
            this.ControlBox = false;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnErrorOk);
            this.Name = "errorBox";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnErrorOk;
        private System.Windows.Forms.Label lblError;
    }
}