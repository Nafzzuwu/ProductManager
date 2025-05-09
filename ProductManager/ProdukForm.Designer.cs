namespace ProductManager
{
    partial class ProdukForm
    {
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.NumericUpDown numHarga;
        private System.Windows.Forms.NumericUpDown numStok;
        private System.Windows.Forms.Button btnSimpan;

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblStok;

        private void InitializeComponent()
        {
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.numHarga = new System.Windows.Forms.NumericUpDown();
            this.numStok = new System.Windows.Forms.NumericUpDown();
            this.btnSimpan = new System.Windows.Forms.Button();

            this.lblNama = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            this.SuspendLayout();

            // lblNama
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNama.Location = new System.Drawing.Point(20, 20);
            this.lblNama.Text = "Nama Produk:";

            // txtNama
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNama.Location = new System.Drawing.Point(140, 17);
            this.txtNama.Size = new System.Drawing.Size(180, 25);
            this.txtNama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblKategori
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKategori.Location = new System.Drawing.Point(20, 60);
            this.lblKategori.Text = "Kategori:";

            // txtKategori
            this.txtKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKategori.Location = new System.Drawing.Point(140, 57);
            this.txtKategori.Size = new System.Drawing.Size(180, 25);
            this.txtKategori.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblHarga
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHarga.Location = new System.Drawing.Point(20, 100);
            this.lblHarga.Text = "Harga:";

            // numHarga
            this.numHarga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numHarga.DecimalPlaces = 2;
            this.numHarga.Location = new System.Drawing.Point(140, 97);
            this.numHarga.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numHarga.Size = new System.Drawing.Size(180, 25);
            this.numHarga.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblStok
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStok.Location = new System.Drawing.Point(20, 140);
            this.lblStok.Text = "Stok:";

            // numStok
            this.numStok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numStok.Location = new System.Drawing.Point(140, 137);
            this.numStok.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numStok.Size = new System.Drawing.Size(180, 25);
            this.numStok.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnSimpan
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(140, 180);
            this.btnSimpan.Size = new System.Drawing.Size(180, 35);
            this.btnSimpan.Text = "💾 Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);

            // ProdukForm
            this.ClientSize = new System.Drawing.Size(360, 240);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.numHarga);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.numStok);
            this.Controls.Add(this.btnSimpan);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdukForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Produk";

            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
