using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //List<string> cars = new List<string>
            //{
            //    "Audi",
            //    "Mercedes",
            //    "Chevrolet",
            //    "Bugatti"
            //};

            //listBox1.DataSource = cars;
            //listBox1.SelectedIndex = 2;
            //listBox1.Items.Add("Maserati");
            //listBox1.Items.Add("Wrangler");

            List<Student> students = new List<Student>
            {
                new Student
                {
                     Name="John",
                     Age=25
                },
                new Student
                {
                     Name="Leyla",
                     Age=32
                },
                new Student
                {
                     Name="Tofiq",
                     Age=42
                },
                new Student
                {
                     Name="Elikram",
                     Age=76
                },
            };

            listBox1.DisplayMember = nameof(Student.Name);
            //listBox1.DataSource = students;
            listBox1.Items.AddRange(students.ToArray());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selectedItem=listBox1.SelectedItem as string;
            //var selectedItem = listBox1.SelectedItem as Student;

            //label1.Text = $"{selectedItem.Id} {selectedItem.Name} {selectedItem.Age}";
            label1.Text = String.Empty;
            var selectedItems = listBox1.SelectedItems;
            foreach (var item in selectedItems)
            {
                var student = item as Student;
                label1.Text += $"{student.Id} {student.Name} {student.Age}\n";
            }

            //MessageBox.Show(selectedItem);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource=null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = String.Empty;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
