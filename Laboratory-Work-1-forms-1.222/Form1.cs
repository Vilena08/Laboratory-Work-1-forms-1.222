using System;
using System.IO;
using System.Windows.Forms;

namespace Laboratory_Work_1_forms_1._2
{
    public partial class Form1 : Form
    {
        string file = "students.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string[] data = {
                "Иванов,Иван,ПИ-21,5",
                "Петров,Петр,ПИ-21,4",
                "Сидорова,Анна,ПИ-22,5",
                "Кузнецов,Олег,ПИ-21,5",
                "Смирнова,Ольга,ПИ-22,3"
            };
            File.WriteAllLines(file, data);
            MessageBox.Show("Файл создан!");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!File.Exists(file))
            {
                MessageBox.Show("Сначала создай файл!");
                return;
            }

            string group = txtGroup.Text;
            string grade = txtGrade.Text;
            string result = "";

            foreach (string line in File.ReadAllLines(file))
            {
                string[] p = line.Split(',');
                if (p.Length == 4 && p[2] == group && p[3] == grade)
                    result += $"{p[0]} {p[1]} — {p[2]} — {p[3]}\n";
            }

            txtResult.Text = result == "" ? "Ничего не найдено" : result;
        }

        private void txtGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}