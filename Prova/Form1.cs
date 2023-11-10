using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = tx_cpf.Text;
            string matricula = tx_matricula.Text;
            DateTime datanasc = Convert.ToDateTime(date_datanasc.Text);
            string sexo = tx_sexo.Text;
            double salario = Convert.ToDouble(tx_salario.Text);

            Funcionario f = new Funcionario(nome, cpf, matricula, datanasc, sexo, salario);



        }
    }
}
