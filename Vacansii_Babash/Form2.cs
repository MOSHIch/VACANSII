using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vacansii_Babash
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rP21_BD_BabashDataSet.Vacancies". При необходимости она может быть перемещена или удалена.
            this.vacanciesTableAdapter.Fill(this.rP21_BD_BabashDataSet.Vacancies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rP21_BD_BabashDataSet1.Human". При необходимости она может быть перемещена или удалена.
            this.humanTableAdapter.Fill(this.rP21_BD_BabashDataSet1.Human);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rP21_BD_BabashDataSet.Human". При необходимости она может быть перемещена или удалена.
            this.humanTableAdapter.Fill(this.rP21_BD_BabashDataSet.Human);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rP21_BD_BabashDataSet.Vacancies". При необходимости она может быть перемещена или удалена.
            this.vacanciesTableAdapter.Fill(this.rP21_BD_BabashDataSet.Vacancies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rP21_BD_BabashDataSet.Field_Of_Activity". При необходимости она может быть перемещена или удалена.
            this.field_Of_ActivityTableAdapter.Fill(this.rP21_BD_BabashDataSet.Field_Of_Activity);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.field_Of_ActivityTableAdapter.Update(this.rP21_BD_BabashDataSet.Field_Of_Activity);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.vacanciesTableAdapter.Update(this.rP21_BD_BabashDataSet.Vacancies);
        }
    }
}
