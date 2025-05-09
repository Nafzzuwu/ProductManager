using ProductManager.Models;
using ProductManager;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class Produk : Form
    {
        public Produk()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using var context = new IsiContext();
            dataGridView1.DataSource = context.Produks.ToList();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var form = new ProdukForm();
            form.ShowDialog();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is ProdukModel selected)
            {
                var form = new ProdukForm(selected.ProductId);
                form.ShowDialog();
                LoadData();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is ProdukModel selected)
            {
                using var context = new IsiContext();
                var entity = context.Produks.Find(selected.ProductId);
                if (entity != null)
                {
                    context.Produks.Remove(entity);
                    context.SaveChanges();
                }
                LoadData();
            }
        }
    }
}