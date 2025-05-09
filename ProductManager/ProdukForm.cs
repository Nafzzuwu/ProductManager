using ProductManager.Models;
using ProductManager;
using System;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class ProdukForm : Form
    {
        private readonly int? productId;

        public ProdukForm(int? id = null)
        {
            InitializeComponent();
            productId = id;

            if (productId.HasValue)
                LoadData();
        }

        private void LoadData()
        {
            using var context = new IsiContext();
            var produk = context.Produks.Find(productId);
            if (produk != null)
            {
                txtNama.Text = produk.ProductName;
                txtKategori.Text = produk.Category;
                numHarga.Value = produk.Price;
                numStok.Value = produk.Stock;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using var context = new IsiContext();
            ProdukModel produk;

            if (productId.HasValue)
            {
                produk = context.Produks.Find(productId);
            }
            else
            {
                produk = new ProdukModel();
                context.Produks.Add(produk);
            }

            produk.ProductName = txtNama.Text;
            produk.Category = txtKategori.Text;
            produk.Price = numHarga.Value;
            produk.Stock = (int)numStok.Value;

            context.SaveChanges();
            Close();
        }
    }
}