using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_jogovelha
{
    public partial class Form1 : Form
    {

        string Njogador1, Njogador2, jogada;
        int cont = 0, Pjogador1 = 0, Pjogador2 = 0, empates = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o Jogo da Velha?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void bt_iniciar_Click(object sender, EventArgs e)
        {

            if ((tb_jogador1.Text != "") && (tb_jogador2.Text != ""))
            {


                //insere jogador e /esconde tb
                Njogador1 = tb_jogador1.Text;
                tb_jogador1.Visible = false;
                lb_jogador.Text = Njogador1 + " joga com ";

                Njogador2 = tb_jogador2.Text;
                tb_jogador2.Visible = false;
                lb_jogador2.Text = Njogador2 + " joga com ";

                //if (lb_jogador.Text == "")
                //{
                //    MessageBox.Show("Insira o nome do jogador "+ lb_jogador.Text);
                //}

                if (rb_X.Checked)
                {
                    lb_jogador.Text = lb_jogador.Text + "X";

                }
                else
                {
                    lb_jogador.Text = lb_jogador.Text + "O";

                }

                if (rb_X.Checked)
                {
                    lb_jogador2.Text = lb_jogador2.Text + "O";
                }
                else
                {
                    lb_jogador2.Text = lb_jogador2.Text + "X";

                }

                gb_opcoes.Enabled = false;
                pnl_bottom2.Enabled = true;

                lb_Pjogador1.Text = "0 - Vitórias";
                lb_Pjogador2.Text = "0 - Vitórias";
                lb_empate.Text = "0 - Empates";

            }
            else
            {
                MessageBox.Show("Informe o nome dos Jogadores", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt1.Text = jogada;
                bt1.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt1.Text = jogada;
                bt1.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt2.Text = jogada;
                bt2.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt2.Text = jogada;
                bt2.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt3.Text = jogada;
                bt3.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt3.Text = jogada;
                bt3.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt4.Text = jogada;
                bt4.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt4.Text = jogada;
                bt4.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt5.Text = jogada;
                bt5.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt5.Text = jogada;
                bt5.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt6.Text = jogada;
                bt6.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt6.Text = jogada;
                bt6.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt7.Text = jogada;
                bt7.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt7.Text = jogada;
                bt7.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt8.Text = jogada;
                bt8.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt8.Text = jogada;
                bt8.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt9.Text = jogada;
                bt9.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt9.Text = jogada;
                bt9.Enabled = false;
            }
            cont++;
            vencedor();
            bt_iniciar.Enabled = false;
            //lb_cont.Text = cont.ToString();

        }

        private void bt_reiniciar_Click(object sender, EventArgs e)
        {
            limpar();
            bt_iniciar.Enabled = true;
            pnl_bottom2.Enabled = false;
            gb_opcoes.Enabled = true;
            lb_Pjogador1.Text = "0 - Vitórias";
            lb_Pjogador2.Text = "0 - Vitórias";
            lb_empate.Text = "0 - Empates";

            tb_jogador1.Text = "";
            Njogador1 = tb_jogador1.Text;
            tb_jogador1.Visible = true;


            tb_jogador2.Text = "";
            Njogador2 = tb_jogador2.Text;
            tb_jogador2.Visible = true;


            if (rb_O.Checked)
            {
                rb_X.Checked = true;
            }
        }


        public void vencedor()
        {
            if (

              //Ganhador na horizontal
              (bt1.Text == "X") && (bt2.Text == "X") && (bt3.Text == "X") ||
              (bt4.Text == "X") && (bt5.Text == "X") && (bt6.Text == "X") ||
              (bt7.Text == "X") && (bt8.Text == "X") && (bt9.Text == "X") ||

              //Ganhador na diagonal
              (bt1.Text == "X") && (bt5.Text == "X") && (bt9.Text == "X") ||
              (bt3.Text == "X") && (bt5.Text == "X") && (bt7.Text == "X") ||

              //Ganhador na vertical
               (bt1.Text == "X") && (bt4.Text == "X") && (bt7.Text == "X") ||
               (bt2.Text == "X") && (bt5.Text == "X") && (bt8.Text == "X") ||
                (bt3.Text == "X") && (bt6.Text == "X") && (bt9.Text == "X"))
            {
                //Mensagem de ganhador /adiciona um ponto ao placar/ limpa os botoes do jogo/Habilita botões/zera contador
                MessageBox.Show("Ganhou!!!", "Parabéns");
                Pjogador1 = Pjogador1 + 1;
                limpar();
                habilitar_botoes();
                lb_Pjogador1.Text = Pjogador1.ToString() + " - Vitória";
                cont = 0;
            }

            else if (
                //Ganhador na horizontal
                (bt1.Text == "O") && (bt2.Text == "O") && (bt3.Text == "O") ||
                (bt4.Text == "O") && (bt5.Text == "O") && (bt6.Text == "O") ||
                (bt7.Text == "O") && (bt8.Text == "O") && (bt9.Text == "O") ||

                //Ganhador na diagonal
                (bt1.Text == "O") && (bt5.Text == "O") && (bt9.Text == "O") ||
                (bt3.Text == "O") && (bt5.Text == "O") && (bt7.Text == "O") ||

                //Ganhador na vertical
               (bt1.Text == "O") && (bt4.Text == "O") && (bt7.Text == "O") ||
               (bt2.Text == "O") && (bt5.Text == "O") && (bt8.Text == "O") ||
                (bt3.Text == "O") && (bt6.Text == "O") && (bt9.Text == "O"))
            {
                //Mensagem de ganhador /adiciona um ponto ao placar/ limpa os botoes do jogo/Habilita botões/zera contador
                MessageBox.Show("Ganhou!!!", "Parabéns");
                Pjogador2 = Pjogador2 + 1;
                limpar();
                habilitar_botoes();
                lb_Pjogador2.Text = Pjogador2.ToString() + " - Vitória";
                cont = 0;
            }

            //Faz a verificação de empate
            if (cont >= 9)
            {
                empates += 1;
                MessageBox.Show("Empatou!!", "Aviso");
                lb_empate.Text = empates.ToString() + " - Empates";
                cont = 0;
                limpar();
                habilitar_botoes();

            }
        }
        //limpa botões do jogo/Habilita botões após limpeza/zera contador
        public void limpar()
        {
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            // pnl_bottom2.Enabled = true;
            habilitar_botoes();
            cont = 0;

        }

        public void habilitar_botoes()
        {
            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;
            bt9.Enabled = true;
        }
    }
}
