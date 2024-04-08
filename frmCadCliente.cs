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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
            //Nescessario para que o sistema não dispere a validação ao clicar no botão cancelar
            AutoValidate = AutoValidate.Disable;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Apresento uma mensagem de SIM ou NÃO 
            //Para confirmação do cancelmento da alteração
            //MessageBoxButtons.YesNo defino que a mensação será do tipo SIM ou Não
            //MessageBoxDefaultButton.Button2 defino que o foco será no NÃO
            //essa configuração essencial caso o cliente aperte o ENTER ou ESPAÇO sem ler a mensagem 
            //Assim ele não irá perder os dados acidentalmente
            //O foco do botão ser no SIM ou no NÃO vai variar de acordo com a instrução da tela
            //DialogResult.Yes verifico se o botão clicado foi o SIM
            if (MessageBox.Show("Deseja realmente descartar as alterações?",
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //validar o campo txtNome
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                //Marca que a execução da rotina precisa ser cancelada
                e.Cancel = true;
                errProvider.SetError(txtNome, "Preencha o nome.");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtNome, "");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Registro salvo com sucesso.", "Informação",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("É necessário o preenchimento de " +
                                "todos os campos obrigatórios.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void txtRG_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRG.Text))
            {
                e.Cancel = true;
                errProvider.SetError(txtRG, "Preencha o RG.");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtRG, "");
            }
        }

        private void mskCPF_Validating(object sender, CancelEventArgs e)
        {
            string numero = "";
            //Percorro todos os caracteres do campo e separo somente os que foram números
            //foreach é laço de repetição semelhente ao for
            //neste cenario ele realiza um loop automatico
            //não precisando informa a quantidade de vezes ou realizar o incremento (i++)
            //useo com cuidado, usado somente em casos oportunos
            foreach (char c in mskCPF.Text)
            {
                if (char.IsNumber(c))
                    numero += c;
            }
            //Após remover todos os caracters da mascara deixando apenas o numeros
            
            //Valido se o campo está vazio ou nullo
            if (string.IsNullOrEmpty(numero))
            {
                e.Cancel = true;
                errProvider.SetError(mskCPF, "Preencha o CPF.");
            }
            //Valido se foi informada a quantidade certo de numeros para o CPF
            else if (numero.Length != 11)
            {
                e.Cancel = true;
                errProvider.SetError(mskCPF, "Preencha o CPF corretamente.");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(mskCPF, "");
            }
        }
    }
}
