using System;
using DemoLibrary;
using System.Windows.Forms;
using DemoLibrary.Models;

namespace TestingDemo
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            txtResult.Text = Calculator.Add((double)num1.Value, (double)num2.Value).ToString();
        }

        private void bntSub_Click(object sender, EventArgs e)
        {
            txtResult.Text = Calculator.Subtract((double)num1.Value, (double)num2.Value).ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtResult.Text = Calculator.Multiply((double)num1.Value, (double)num2.Value).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (num2.Value == 0)
            {
                MessageBox.Show("O segundo número deve ser diferente de zero");
                return;
            }

            txtResult.Text = Calculator.Divide((double)num1.Value, (double)num2.Value).ToString();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            DataAccess.AddNewPerson(new PersonModel() { FisrtName = txtNome.Text, LastName = txtSobrenome.Text});
            carregarPessoas();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cmbUsers.DisplayMember = "FullName";
            cmbUsers.ValueMember = "FullName";

            carregarPessoas();
        }

        private void carregarPessoas()
        {
            var people = DataAccess.GetAllPeople();
            cmbUsers.DataSource = people;
        }
    }
}
