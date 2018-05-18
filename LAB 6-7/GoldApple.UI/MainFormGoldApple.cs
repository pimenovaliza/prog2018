using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldApple.UI
{
    public partial class MainFormGoldApple : Form
    {
        public MainFormGoldApple()
        {
            InitializeComponent();
            
        }

        ProductRequestDto GetModelFromUI()
        {
            return new ProductRequestDto()
            {
                Filled = dateTimePicker1.Value,
                Description = listBox1.Items.OfType<Description>().ToList(),
                FullName = textBox1.Text,
                Brend= textBox2.Text,
                 
            };
        }
        
        private void SetModelToUI(ProductRequestDto dto)
        {
            dateTimePicker1.Value = dto.Filled;
            textBox1.Text = dto.FullName;
            textBox2.Text = dto.Brend;
            listBox1.Items.Clear();
            foreach (var e in dto.Description)
            {
                listBox1.Items.Add(e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Файлы продуктов|*.goldapple" };
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = GetModelFromUI();
                ProductDtoHelper.WriteToFile(sfd.FileName, dto);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Файл продукта|*.goldapple" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = ProductDtoHelper.LoadFromFile(ofd.FileName);
                SetModelToUI(dto);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new DescriptionForm(new Description());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                listBox1.Items.Add(form.des);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var des = listBox1.SelectedItem as Description;
            if (des == null)
                return;
            var form = new DescriptionForm(des.Clone());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                var si = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(si);
                listBox1.Items.Insert(si, form.des);
            }
            button4.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var si = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(si);
        }

    }
}

