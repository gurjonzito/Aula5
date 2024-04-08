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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            //Nescessario chamar o método aqui para abrir a tela com a data e hora atualizador
            //Se não os valores ficaram zerado até a execução do timer
            //Ou seja fica 00:00:00 por 1 segundo até o timer rodar
            AtualizarDataHora();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Método que é executado na abertura da tela
            //No momento que a tela é exibida para o usuário 
            //Executado após o InitializeComponent(); acima

            //Altero o titulo da tela para acrescenta a versão do sistema
            this.Text = this.Text + " - Versão: " + Application.ProductVersion.ToString();

            //Configuro a exibição de discas (Hint) para o componente Button
            //No caso os botões de atalhos
            toolTipAtalhos.SetToolTip(this.btnCliente, "Cadastro de Clientes.");
            toolTipAtalhos.SetToolTip(this.btnProduto, "Cadastro de Produtos.");
            toolTipAtalhos.SetToolTip(this.btnSair, "Sair do Sistema.");
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Método que é executado automaticamente quando a tela recebe um comendo de fechar
            //neste momento é possivel cancelar o fechamento da tela

            if (MessageBox.Show("Deseja sair ?",
               "Atenção",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button2
               ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void AtualizarDataHora()
        {
            //Atualizo a label da hora 
            //Chamo o componente DateTime
            //Uso o método Now que retornar a data e hora atual da maquina
            //Converto o DateTime do Now para string ja no formato desejado
            //ToLong é o formato completo
            //ToShort é o formato curto
            //E defino a informação que quero Time para Hora e Date para data
            //lblHora.Text = DateTime.Now.ToLongTimeString(); // 00:00:00 - hh:mm:ss - hora minuto e segundo
            //lblHora.Text = DateTime.Now.ToShortTimeString(); // 00:00 - hh:mm
            //lblData.Text = DateTime.Now.ToLongDateString(); // segunda-feira, 11 de setembro de 2023 apresenta a data por extenso
            //lblData.Text = DateTime.Now.ToShortDateString(); // 00/00/0000 - dd/MM/yyyy - dia mes e ano

            //Para esse sitema eu escolhi a hora complete e a data curta para ficar visualmente mais agradavel
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            //De acordo com a propriedade do Timer
            //Enable = True
            //Interval = 1000 (milessimos)
            //O Timer ira iniciar ligado devido o enable true
            //ou seja ao iniciar o sistema ele ira executar automaticamente
            //e será executa a cada um segundo
            //Ou seja a cada 1 segundo irá chamar o método que atualiza a data e hora
            AtualizarDataHora();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Defino o componente
            //defino o nome da variavel
            //Crio uma nova instancia

            frmCadCliente frm = new frmCadCliente();

            //Show abre uma nova janela a parte
            //ShowDialog abre uma nova janela fixa a tela anterior
            frm.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //Para evitar duplicação de código na chamada da tela de Cadastro de Clientes
            //Eu posso simular um clik de botão chamando o método PerformClick do botão desejado
            //Ele simula o click do usuario no botão executando a ação dele
            clientesToolStripMenuItem.PerformClick();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadProduto frm = new frmCadProduto();

            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            sairToolStripMenuItem.PerformClick();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            produtosToolStripMenuItem.PerformClick();
        }
    }
}
