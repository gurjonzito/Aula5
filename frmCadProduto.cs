using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5
{
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();

            AutoValidate = AutoValidate.Disable;
        }

        bool IsNumber(string value)
        {
            if (value == null)
            {
                return false;
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                    return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o processo?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Registro salvo com sucesso.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos, por favor.",
                    "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDesc, "Preencha a descrição.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDesc, null);
            }
        }

        private void mskCod_Validating(object sender, CancelEventArgs e)
        {
            string numero = null;

            foreach (char c in mskCod.Text)
            {
                if (char.IsNumber(c))
                    numero += c;
            }

            if (string.IsNullOrEmpty(numero))
            {
                e.Cancel = true;
                errorProvider.SetError(mskCod, "Preencha o código de barras.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(mskCod, null);
            }

            if (string.IsNullOrEmpty(numero))
            {
                e.Cancel = true;
                errorProvider.SetError(mskCod, "Preencha o código de barras.");
            }

            else if (numero.Length != 13)
            {
                e.Cancel = true;
                errorProvider.SetError(mskCod, "Preencha o código de barras corretamente.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(mskCod, null);
            }
        }

        private void boxUn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(boxUn.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(boxUn, "Selecione a unidade.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(boxUn, null);
            }
        }

        private void boxCat_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(boxCat.Text))
            {
                e.Cancel= true;
                errorProvider.SetError(boxCat, "Selecione a categoria.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(boxCat, null);
            }
        }

        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtValor, "Preencha o valor de venda.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtValor, null);
            }

            if (IsNumber(txtValor.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(txtValor, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(txtValor, "Preencha apenas números.");
            }
        }
    }
}
