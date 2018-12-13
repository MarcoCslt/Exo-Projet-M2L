namespace M2L
{
    partial class ListeAdherents
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNom,
            this.clmPrenom,
            this.clmDateAd});
            this.dataGridView1.Location = new System.Drawing.Point(227, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmNom
            // 
            this.clmNom.HeaderText = "Nom";
            this.clmNom.Name = "clmNom";
            // 
            // clmPrenom
            // 
            this.clmPrenom.HeaderText = "Prenom";
            this.clmPrenom.Name = "clmPrenom";
            // 
            // clmDateAd
            // 
            this.clmDateAd.HeaderText = "Date Adhésion";
            this.clmDateAd.Name = "clmDateAd";
            // 
            // ListeAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListeAdherents";
            this.Text = "Liste de tous les adhérents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateAd;
    }
}