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
    public partial class DescriptionForm : Form
    {
        public Description des { get; set; }
        public DescriptionForm(Description des)
        {
            this.des = des;
            InitializeComponent();
            ComboBox1();
        }

        private void ComboBox1()
        {
            comboBox1.Items.Add(Currency.Dollars);
            comboBox1.Items.Add(Currency.Rubles);
        }

        //private void Saver1(Description o)
        //{
        //    if (comboBox1.SelectedIndex == 0)
        //        o.Currency = Currency.Dollars;
        //    if (comboBox1.SelectedIndex == 1)
        //        o.Currency = Currency.Rubles;
        //}
        private void DescriptionForm_Load(object sender, EventArgs e)
        {
            textBox2.Text = des.Amount;
            textBox3.Text = des.Color;
            textBox4.Text = des.Code;
            numericUpDown1.Value = des.Price;

            if (des.Currency == Currency.Dollars)
                comboBox1.SelectedIndex = 0;
            if (des.Currency == Currency.Rubles)
                comboBox1.SelectedIndex = 1;


            switch (des.Type)
            {
                case ProductsType.MassMarket:
                    radioButton1.Checked = true;
                    break;
                case ProductsType.Prof:
                    radioButton2.Checked = true;
                    break;
                case ProductsType.Lux:
                    radioButton3.Checked = true;
                    break;
            }
        }

        //Description GetModelFromUI()
        //{
        //    var a = Convert.ToDouble(textBox2.Text);
        //    var b = Convert.ToDouble(textBox4.Text);
        //    return new Description()
        //    {
        //    Amount = a,
        //    Color = textBox3.Text,
        //    Code = b,
        //    Price = numericUpDown1.Value,
        //    };
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //var dto = GetModelFromUI();
            // Saver1(dto);
            des.Amount = textBox2.Text;
            des.Color = textBox3.Text;
            des.Code = textBox4.Text;
            des.Price = numericUpDown1.Value;

            if (comboBox1.SelectedIndex == 0)
                des.Currency = Currency.Dollars;
            if (comboBox1.SelectedIndex == 1)
                des.Currency = Currency.Rubles;
            if (radioButton1.Checked)
                des.Type = ProductsType.MassMarket;
            if (radioButton2.Checked)
                des.Type = ProductsType.Prof;
            if (radioButton3.Checked)
                des.Type = ProductsType.Lux;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
