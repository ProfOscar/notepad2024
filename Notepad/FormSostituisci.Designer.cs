namespace Notepad
{
    partial class FormSostituisci
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSostituisci = new System.Windows.Forms.Label();
            this.txtSostituisci = new System.Windows.Forms.TextBox();
            this.btnSostituisci = new System.Windows.Forms.Button();
            this.btnSostituisciTutto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(338, 141);
            // 
            // txtTrova
            // 
            this.txtTrova.Location = new System.Drawing.Point(130, 15);
            this.txtTrova.Size = new System.Drawing.Size(192, 26);
            // 
            // lblSostituisci
            // 
            this.lblSostituisci.AutoSize = true;
            this.lblSostituisci.Location = new System.Drawing.Point(9, 69);
            this.lblSostituisci.Name = "lblSostituisci";
            this.lblSostituisci.Size = new System.Drawing.Size(115, 20);
            this.lblSostituisci.TabIndex = 6;
            this.lblSostituisci.Text = "Sostituisci con:";
            // 
            // txtSostituisci
            // 
            this.txtSostituisci.Location = new System.Drawing.Point(130, 66);
            this.txtSostituisci.Name = "txtSostituisci";
            this.txtSostituisci.Size = new System.Drawing.Size(192, 26);
            this.txtSostituisci.TabIndex = 7;
            // 
            // btnSostituisci
            // 
            this.btnSostituisci.Location = new System.Drawing.Point(338, 55);
            this.btnSostituisci.Name = "btnSostituisci";
            this.btnSostituisci.Size = new System.Drawing.Size(170, 35);
            this.btnSostituisci.TabIndex = 8;
            this.btnSostituisci.Text = "Sostituisci";
            this.btnSostituisci.UseVisualStyleBackColor = true;
            // 
            // btnSostituisciTutto
            // 
            this.btnSostituisciTutto.Location = new System.Drawing.Point(338, 98);
            this.btnSostituisciTutto.Name = "btnSostituisciTutto";
            this.btnSostituisciTutto.Size = new System.Drawing.Size(170, 35);
            this.btnSostituisciTutto.TabIndex = 9;
            this.btnSostituisciTutto.Text = "Sostituisci tutto";
            this.btnSostituisciTutto.UseVisualStyleBackColor = true;
            // 
            // FormSostituisci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(525, 183);
            this.Controls.Add(this.btnSostituisciTutto);
            this.Controls.Add(this.btnSostituisci);
            this.Controls.Add(this.txtSostituisci);
            this.Controls.Add(this.lblSostituisci);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FormSostituisci";
            this.Text = "Sostituisci";
            this.Controls.SetChildIndex(this.txtTrova, 0);
            this.Controls.SetChildIndex(this.btnAnnulla, 0);
            this.Controls.SetChildIndex(this.lblSostituisci, 0);
            this.Controls.SetChildIndex(this.txtSostituisci, 0);
            this.Controls.SetChildIndex(this.btnSostituisci, 0);
            this.Controls.SetChildIndex(this.btnSostituisciTutto, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSostituisci;
        private System.Windows.Forms.TextBox txtSostituisci;
        private System.Windows.Forms.Button btnSostituisci;
        private System.Windows.Forms.Button btnSostituisciTutto;
    }
}
