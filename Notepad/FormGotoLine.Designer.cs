namespace Notepad
{
    partial class FormGotoLine
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
            this.components = new System.ComponentModel.Container();
            this.lblNumRiga = new System.Windows.Forms.Label();
            this.txtNumRiga = new System.Windows.Forms.TextBox();
            this.btnVai = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.errorProviderTxtNumRiga = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxtNumRiga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumRiga
            // 
            this.lblNumRiga.AutoSize = true;
            this.lblNumRiga.Location = new System.Drawing.Point(9, 19);
            this.lblNumRiga.Name = "lblNumRiga";
            this.lblNumRiga.Size = new System.Drawing.Size(67, 13);
            this.lblNumRiga.TabIndex = 0;
            this.lblNumRiga.Text = "Numero riga:";
            // 
            // txtNumRiga
            // 
            this.txtNumRiga.Location = new System.Drawing.Point(82, 16);
            this.txtNumRiga.Name = "txtNumRiga";
            this.txtNumRiga.Size = new System.Drawing.Size(100, 20);
            this.txtNumRiga.TabIndex = 1;
            this.txtNumRiga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRiga_KeyPress);
            // 
            // btnVai
            // 
            this.btnVai.Location = new System.Drawing.Point(12, 59);
            this.btnVai.Name = "btnVai";
            this.btnVai.Size = new System.Drawing.Size(75, 23);
            this.btnVai.TabIndex = 2;
            this.btnVai.Text = "Vai a";
            this.btnVai.UseVisualStyleBackColor = true;
            this.btnVai.Click += new System.EventHandler(this.btnVai_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(131, 59);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 3;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // errorProviderTxtNumRiga
            // 
            this.errorProviderTxtNumRiga.ContainerControl = this;
            // 
            // FormGotoLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 94);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnVai);
            this.Controls.Add(this.txtNumRiga);
            this.Controls.Add(this.lblNumRiga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGotoLine";
            this.Text = "Vai alla riga";
            this.Load += new System.EventHandler(this.FormGotoLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxtNumRiga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumRiga;
        private System.Windows.Forms.TextBox txtNumRiga;
        private System.Windows.Forms.Button btnVai;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.ErrorProvider errorProviderTxtNumRiga;
    }
}