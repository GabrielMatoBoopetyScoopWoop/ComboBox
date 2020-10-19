namespace combobox
{
    partial class ComboBox
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
            this.CmbIzbor = new System.Windows.Forms.ComboBox();
            this.btnPoruka = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbIzbor
            // 
            this.CmbIzbor.FormattingEnabled = true;
            this.CmbIzbor.Items.AddRange(new object[] {
            "",
            "Auto",
            "Vetura",
            "Automobil"});
            this.CmbIzbor.Location = new System.Drawing.Point(176, 102);
            this.CmbIzbor.Name = "CmbIzbor";
            this.CmbIzbor.Size = new System.Drawing.Size(121, 21);
            this.CmbIzbor.TabIndex = 0;
            this.CmbIzbor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnPoruka
            // 
            this.btnPoruka.Location = new System.Drawing.Point(490, 379);
            this.btnPoruka.Name = "btnPoruka";
            this.btnPoruka.Size = new System.Drawing.Size(227, 23);
            this.btnPoruka.TabIndex = 1;
            this.btnPoruka.Text = "Prikaži poruku";
            this.btnPoruka.UseVisualStyleBackColor = true;
            this.btnPoruka.Click += new System.EventHandler(this.btnPoruka_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(176, 173);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(121, 20);
            this.txtIspis.TabIndex = 2;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(490, 333);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(227, 23);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbriši Poruku";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.btnPoruka);
            this.Controls.Add(this.CmbIzbor);
            this.Name = "ComboBox";
            this.Text = "ComboBoxVjezba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbIzbor;
        private System.Windows.Forms.Button btnPoruka;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}

