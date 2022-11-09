using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace FileIODemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp1 = new Employee();
                FileStream fs = new FileStream(@"E:\Cybage\emp_binary.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                emp1 = (Employee)binary.Deserialize(fs);
                txtId.Text = emp1.Id.ToString();
                txtName.Text = emp1.Name;
                txtSalary.Text = emp1.Salary.ToString();
                fs.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"E:\Cybage\emp_json.json", FileMode.Open, FileAccess.Read);
                emp = JsonSerializer.Deserialize<Employee>(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
                fs.Close();


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp1 = new Employee();
                emp1.Id = Convert.ToInt32(txtId.Text);
                emp1.Name = txtName.Text;
                emp1.Salary = Convert.ToInt32(txtSalary.Text); 
                FileStream fs = new FileStream(@"E:\Cybage\empdata.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, emp1);
                fs.Close();
                MessageBox.Show("Serialized the data using soap");


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);

                FileStream fs = new FileStream(@"E:\Cybage\emp_binary.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Saved data using binary serializer");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp1 = new Employee();
                
                FileStream fs = new FileStream(@"E:\Cybage\empdata.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                emp1 = (Employee)soap.Deserialize(fs);
                txtId.Text = emp1.Id.ToString();
                txtName.Text = emp1.Name;
                txtSalary.Text = emp1.Salary.ToString();
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxmlwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp1 = new Employee();
                emp1.Id = Convert.ToInt32(txtId.Text);
                emp1.Name = txtName.Text;
                emp1.Salary = Convert.ToInt32(txtSalary.Text);
                FileStream fs = new FileStream(@"E:\Cybage\emp1_xml.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, emp1);
                fs.Close();
                MessageBox.Show("Serialized the data through XMLSerializer");


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxmlread_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp1 = new Employee();
                FileStream fs = new FileStream(@"E:\Cybage\emp1_xml.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                emp1 = (Employee)xml.Deserialize(fs);
                txtId.Text = emp1.Id.ToString();
                txtName.Text = emp1.Name;
                txtSalary.Text = emp1.Salary.ToString();
                fs.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                FileStream fs = new FileStream(@"E:\Cybage\emp_json.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();
                MessageBox.Show("Data serialized using Json serialization");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
