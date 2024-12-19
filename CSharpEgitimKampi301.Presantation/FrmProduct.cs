using CSharpEgitimKampi301.Bussiness.Abstract;
using CSharpEgitimKampi301.Bussiness.Concrete;
using CSharpEgitimKampi301.DataAccess.EntityFramework;
using CSharpEgitimKampi301.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.Presantation
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
      
        public FrmProduct(IProductService productService)
        {
          
            _productService = new ProductManager(new EfProductDal());  
            InitializeComponent();
        }

        public FrmProduct()
        {
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource=values;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.CategoryId = int.Parse(cmbCategory.Text);
            p.ProductPrice = decimal.Parse(txtProductPrice.Text);
            p.ProductName = txtProductName.Text;
            p.ProductDescription = txtDescription.Text;
            p.ProductStock = int.Parse(txtProductStock.Text);
            _productService.TInsert(p);
            MessageBox.Show("Ekleme işlemi yapıldı");
        }
    }
}
