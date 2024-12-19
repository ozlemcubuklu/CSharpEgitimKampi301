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
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;
    

        public FrmCategory()
        {  
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryvalue = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryvalue;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;

            category.CategoryStatus = true;

            _categoryService.TInsert(category);
            MessageBox.Show("Kategori eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletevalue = _categoryService.TGetById(id);
            _categoryService.TDelete(deletevalue);
            MessageBox.Show("Kategori silindi.");
        }

        private void btnGetbyId_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtCategoryId.Text);
            var value = _categoryService.TGetById(id);
            dataGridView1.DataSource = value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var updatevalue = _categoryService.TGetById(id);
            updatevalue.CategoryName = txtCategoryName.Text;
            updatevalue.CategoryStatus = true;
            MessageBox.Show("Kategori güncellendi.");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCategoryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
