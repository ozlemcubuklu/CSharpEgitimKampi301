using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EfProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guide.Where(x=>x.Id==id).ToList();
            dataGridView1.DataSource = values;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removevalue = db.Guide.Find(id);
            db.Guide.Remove(removevalue);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silindi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatevalue=db.Guide.Find(id);
            updatevalue.Name=txtName.Text;
            updatevalue.Surname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.Name = txtName.Text;
            guide.Surname = txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }
    }
}
