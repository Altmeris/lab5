using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Поставщик_ингредиентов". При необходимости она может быть перемещена или удалена.
            this.поставщик_ингредиентовTableAdapter.Fill(this.uPDataSet.Поставщик_ингредиентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.uPDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.uPDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Тип_товаров". При необходимости она может быть перемещена или удалена.
            this.тип_товаровTableAdapter.Fill(this.uPDataSet.Тип_товаров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.uPDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this.uPDataSet.Заказчик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.uPDataSet.Заказ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказBindingSource.EndEdit();
            заказTableAdapter.Update(uPDataSet);
            MessageBox.Show("Данные сохранены", "Message");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.EndEdit();
            сотрудникиTableAdapter.Update(uPDataSet);
            MessageBox.Show("Данные сохранены", "Message");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            товарBindingSource.EndEdit();
            товарTableAdapter.Update(uPDataSet);
            MessageBox.Show("Данные сохранены", "Message");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            поставщикингредиентовBindingSource.EndEdit();
            поставщик_ингредиентовTableAdapter.Update(uPDataSet);
            MessageBox.Show("Данные сохранены", "Message");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            типтоваровBindingSource.EndEdit();
            тип_товаровTableAdapter.Update(uPDataSet);
            MessageBox.Show("Данные сохранены", "Message");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            должностьBindingSource.EndEdit();
            должностьTableAdapter.Update(uPDataSet);
            MessageBox.Show("Данные сохранены", "Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            заказчикBindingSource.EndEdit();
            заказчикTableAdapter.Update(uPDataSet);
            MessageBox.Show("Данные сохранены", "Message");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            String input = textBox1.Text;
            String data = comboBox1.Text;
            заказBindingSource.Filter = string.Format("`{0}` = '{1}'", data, input);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            заказBindingSource.Filter = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String input = textBox4.Text;
            String data = comboBox3.Text;
            сотрудникиBindingSource.Filter = string.Format("`{0}` = '{1}'", data, input);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.Filter = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            String input = textBox6.Text;
            String data = comboBox2.Text;
            товарBindingSource.Filter = string.Format("`{0}` = '{1}'", data, input);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            товарBindingSource.Filter = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            String input = textBox7.Text;
            String data = comboBox4.Text;
            поставщикингредиентовBindingSource.Filter = string.Format("`{0}` = '{1}'", data, input);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            поставщикингредиентовBindingSource.Filter = null;
        }
    }
}
