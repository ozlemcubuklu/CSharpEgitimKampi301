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
    public partial class FrmProduct1 : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct1()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService=new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            p.ProductPrice = decimal.Parse(txtProductPrice.Text);
            p.ProductName = txtProductName.Text;
            p.ProductDescription = txtDescription.Text;
            p.ProductStock = int.Parse(txtProductStock.Text);
            _productService.TInsert(p);
            MessageBox.Show("Ekleme işlemi yapıldı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            MessageBox.Show("silme işlemi başarılı");
        }

        private void btnGetbyId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value=_productService.TGetById(id);
            dataGridView1.DataSource=value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            value.ProductDescription = txtDescription.Text;
            value.ProductPrice= decimal.Parse(txtProductPrice.Text);
            value.ProductName= txtProductName.Text;
            value.ProductStock= int.Parse(txtProductStock.Text);
            value.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            _productService.TUpdate(value);
            MessageBox.Show("Güncelleme işlemi başarı ile yapıldı.");
        }

        private void FrmProduct1_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbCategory.DataSource=values;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }
    }
}
