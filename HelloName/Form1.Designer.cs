namespace HelloName
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
            this.lblYourname = new System.Windows.Forms.Label();
            this.txtYourname = new System.Windows.Forms.TextBox();
            this.btnSayhello = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYourname
            // 
            this.lblYourname.AutoSize = true;
            this.lblYourname.Location = new System.Drawing.Point(69, 32);
            this.lblYourname.Name = "lblYourname";
            this.lblYourname.Size = new System.Drawing.Size(89, 16);
            this.lblYourname.TabIndex = 0;
            this.lblYourname.Text = "Write ur name";
            this.lblYourname.MouseLeave += new System.EventHandler(this.lblYourname_MouseLeave);
            this.lblYourname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblYourname_MouseMove);
            // 
            // txtYourname
            // 
            this.txtYourname.Location = new System.Drawing.Point(185, 26);
            this.txtYourname.Name = "txtYourname";
            this.txtYourname.Size = new System.Drawing.Size(483, 22);
            this.txtYourname.TabIndex = 1;
            this.txtYourname.TextChanged += new System.EventHandler(this.txtYourname_TextChanged);
            // 
            // btnSayhello
            // 
            this.btnSayhello.Location = new System.Drawing.Point(37, 172);
            this.btnSayhello.Name = "btnSayhello";
            this.btnSayhello.Size = new System.Drawing.Size(189, 58);
            this.btnSayhello.TabIndex = 2;
            this.btnSayhello.Text = "&Say Hello";
            this.btnSayhello.UseVisualStyleBackColor = true;
            this.btnSayhello.Click += new System.EventHandler(this.btnSayhello_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(311, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 58);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(589, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(118, 341);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSayhello);
            this.Controls.Add(this.txtYourname);
            this.Controls.Add(this.lblYourname);
            this.Name = "Form1";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYourname;
        private System.Windows.Forms.TextBox txtYourname;
        private System.Windows.Forms.Button btnSayhello;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
    }
}

