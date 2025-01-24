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
            this.lblTrova.Location = new System.Drawing.Point(9, 20);
            this.lblTrova.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrova.Name = "lblTrova";
            this.lblTrova.Size = new System.Drawing.Size(52, 20);
            this.lblTrova.TabIndex = 0;
            this.lblTrova.Text = "Trova:";
            // 
            // txtTrova
            // 
            this.txtTrova.Location = new System.Drawing.Point(86, 15);
            this.txtTrova.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrova.Name = "txtTrova";
            this.txtTrova.Size = new System.Drawing.Size(236, 26);
            this.txtTrova.TabIndex = 1;
            // 
            // btnTrova
            // 
            this.btnTrova.Location = new System.Drawing.Point(338, 12);
            this.btnTrova.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrova.Name = "btnTrova";
            this.btnTrova.Size = new System.Drawing.Size(170, 35);
            this.btnTrova.TabIndex = 2;
            this.btnTrova.Text = "Trova successivo";
            this.btnTrova.UseVisualStyleBackColor = true;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(338, 62);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(170, 35);
            this.btnAnnulla.TabIndex = 3;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            // 
            // chkTestoIntorno
            // 
            this.chkTestoIntorno.AutoSize = true;
            this.chkTestoIntorno.Location = new System.Drawing.Point(14, 155);
            this.chkTestoIntorno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTestoIntorno.Name = "chkTestoIntorno";
            this.chkTestoIntorno.Size = new System.Drawing.Size(128, 24);
            this.chkTestoIntorno.TabIndex = 4;
            this.chkTestoIntorno.Text = "Testo intorno";
            this.chkTestoIntorno.UseVisualStyleBackColor = true;
            // 
            // chkMaiusMinus
            // 
            this.chkMaiusMinus.AutoSize = true;
            this.chkMaiusMinus.Location = new System.Drawing.Point(14, 120);
            this.chkMaiusMinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMaiusMinus.Name = "chkMaiusMinus";
            this.chkMaiusMinus.Size = new System.Drawing.Size(181, 24);
            this.chkMaiusMinus.TabIndex = 5;
            this.chkMaiusMinus.Text = "Maiuscole/minuscole";
            this.chkMaiusMinus.UseVisualStyleBackColor = true;
            // 
            // FormBaseTrovaSostituisci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 183);
            this.Controls.Add(this.chkMaiusMinus);
            this.Controls.Add(this.chkTestoIntorno);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnTrova);
            this.Controls.Add(this.txtTrova);
            this.Controls.Add(this.lblTrova);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBaseTrovaSostituisci";
            this.Text = "FormBaseTrovaSostituisci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrova;
        private System.Windows.Forms.Button btnTrova;
        private System.Windows.Forms.CheckBox chkTestoIntorno;
        private System.Windows.Forms.CheckBox chkMaiusMinus;
        protected System.Windows.Forms.Button btnAnnulla;
        protected System.Windows.Forms.TextBox txtTrova;
    }
}