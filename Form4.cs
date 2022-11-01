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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.uPDataSet.Должность);
            comboBox3.SelectedIndex = 1;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.uPDataSet.Сотрудники);
            comboBox1.SelectedIndex = 3;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Выплаты". При необходимости она может быть перемещена или удалена.
            this.выплатыTableAdapter.Fill(this.uPDataSet.Выплаты);
            comboBox2.SelectedIndex = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            выплатыBindingSource.EndEdit();
            выплатыTableAdapter.Update(uPDataSet);
            MessageBox.Show("Данные сохранены", "Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.EndEdit();
            сотрудникиTableAdapter.Update(uPDataSet);
            MessageBox.Show("Данные сохранены", "Message");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            должностьBindingSource.EndEdit();
            должностьTableAdapter.Update(uPDataSet);
            MessageBox.Show("Данные сохранены", "Message");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String input = textchange2.Text;
            String data = comboBox1.Text;
            сотрудникиBindingSource.Filter = string.Format("`{0}` = '{1}'", data, input);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.Filter = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            выплатыBindingSource2.Filter = string.Format("`{0}` = '{1}'", comboBox2.Text, textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            выплатыBindingSource2.Filter = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            должностьBindingSource.Filter = string.Format("`{0}` = '{1}'", comboBox3.Text, textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            должностьBindingSource.Filter = null;
        }

    }
}
