namespace Notepad
{
    partial class FormBaseTrovaSostituisci
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
            this.lblTrova = new System.Windows.Forms.Label();
            this.txtTrova = new System.Windows.Forms.TextBox();
            this.btnTrova = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.chkTestoIntorno = new System.Windows.Forms.CheckBox();
            this.chkMaiusMinus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTrova
            // 
            this.lblTrova.AutoSize = true;
            this.lblTrova.Location = new System.Drawing.Point(6, 13);
            this.lblTrova.Name = "lblTrova";
            this.lblTrova.Size = new System.Drawing.Size(38, 13);
            this.lblTrova.TabIndex = 0;
            this.lblTrova.Text = "Trova:";
            // 
            // txtTrova
            // 
            this.txtTrova.Location = new System.Drawing.Point(57, 10);
            this.txtTrova.Name = "txtTrova";
            this.txtTrova.Size = new System.Drawing.Size(159, 20);
            this.txtTrova.TabIndex = 1;
            // 
            // btnTrova
            // 
            this.btnTrova.Location = new System.Drawing.Point(225, 8);
            this.btnTrova.Name = "btnTrova";
            this.btnTrova.Size = new System.Drawing.Size(113, 23);
            this.btnTrova.TabIndex = 2;
            this.btnTrova.Text = "Trova successivo";
            this.btnTrova.UseVisualStyleBackColor = true;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(225, 40);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(113, 23);
            this.btnAnnulla.TabIndex = 3;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            // 
            // chkTestoIntorno
            // 
            this.chkTestoIntorno.AutoSize = true;
            this.chkTestoIntorno.Location = new System.Drawing.Point(9, 101);
            this.chkTestoIntorno.Name = "chkTestoIntorno";
            this.chkTestoIntorno.Size = new System.Drawing.Size(88, 17);
            this.chkTestoIntorno.TabIndex = 4;
            this.chkTestoIntorno.Text = "Testo intorno";
            this.chkTestoIntorno.UseVisualStyleBackColor = true;
            // 
            // chkMaiusMinus
            // 
            this.chkMaiusMinus.AutoSize = true;
            this.chkMaiusMinus.Location = new System.Drawing.Point(9, 78);
            this.chkMaiusMinus.Name = "chkMaiusMinus";
            this.chkMaiusMinus.Size = new System.Drawing.Size(126, 17);
            this.chkMaiusMinus.TabIndex = 5;
            this.chkMaiusMinus.Text = "Maiuscole/minuscole";
            this.chkMaiusMinus.UseVisualStyleBackColor = true;
            // 
            // FormBaseTrovaSostituisci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 119);
            this.Controls.Add(this.chkMaiusMinus);
            this.Controls.Add(this.chkTestoIntorno);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnTrova);
            this.Controls.Add(this.txtTrova);
            this.Controls.Add(this.lblTrova);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBaseTrovaSostituisci";
            this.Text = "FormBaseTrovaSostituisci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrova;
        private System.Windows.Forms.TextBox txtTrova;
        private System.Windows.Forms.Button btnTrova;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.CheckBox chkTestoIntorno;
        private System.Windows.Forms.CheckBox chkMaiusMinus;
    }
}