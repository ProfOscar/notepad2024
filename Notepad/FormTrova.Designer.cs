namespace Notepad
{
    partial class FormTrova
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
            this.gbDirezione = new System.Windows.Forms.GroupBox();
            this.rdbGiu = new System.Windows.Forms.RadioButton();
            this.rdbSu = new System.Windows.Forms.RadioButton();
            this.gbDirezione.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTrova
            // 
            this.txtTrova.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // gbDirezione
            // 
            this.gbDirezione.Controls.Add(this.rdbGiu);
            this.gbDirezione.Controls.Add(this.rdbSu);
            this.gbDirezione.Location = new System.Drawing.Point(124, 34);
            this.gbDirezione.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDirezione.Name = "gbDirezione";
            this.gbDirezione.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDirezione.Size = new System.Drawing.Size(91, 46);
            this.gbDirezione.TabIndex = 6;
            this.gbDirezione.TabStop = false;
            this.gbDirezione.Text = "Direzione";
            // 
            // rdbGiu
            // 
            this.rdbGiu.AutoSize = true;
            this.rdbGiu.Checked = true;
            this.rdbGiu.Location = new System.Drawing.Point(45, 16);
            this.rdbGiu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbGiu.Name = "rdbGiu";
            this.rdbGiu.Size = new System.Drawing.Size(41, 17);
            this.rdbGiu.TabIndex = 1;
            this.rdbGiu.TabStop = true;
            this.rdbGiu.Text = "Giù";
            this.rdbGiu.UseVisualStyleBackColor = true;
            // 
            // rdbSu
            // 
            this.rdbSu.AutoSize = true;
            this.rdbSu.Location = new System.Drawing.Point(5, 17);
            this.rdbSu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbSu.Name = "rdbSu";
            this.rdbSu.Size = new System.Drawing.Size(38, 17);
            this.rdbSu.TabIndex = 0;
            this.rdbSu.Text = "Su";
            this.rdbSu.UseVisualStyleBackColor = true;
            this.rdbSu.CheckedChanged += new System.EventHandler(this.rdbSu_CheckedChanged);
            // 
            // FormTrova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(350, 119);
            this.Controls.Add(this.gbDirezione);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTrova";
            this.Text = "Trova";
            this.Load += new System.EventHandler(this.FormTrova_Load);
            this.Controls.SetChildIndex(this.txtTrova, 0);
            this.Controls.SetChildIndex(this.btnAnnulla, 0);
            this.Controls.SetChildIndex(this.gbDirezione, 0);
            this.gbDirezione.ResumeLayout(false);
            this.gbDirezione.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDirezione;
        private System.Windows.Forms.RadioButton rdbGiu;
        private System.Windows.Forms.RadioButton rdbSu;
    }
}
