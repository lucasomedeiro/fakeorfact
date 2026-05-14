using System;
using System.Windows.Forms;

namespace FakeOrFact
{
    public partial class Form1 : Form
    {
        private Jogo? _jogo; // CORRIGIDO: declarado como anulável com "?"
        private int _segundoRestantes;
        private const int TEMPO_POR_CATEGORIA = 15;

        public Form1()
        {
            InitializeComponent();
            ConfigurarComboBox();
        }

        private void IniciarTimer()
        {
            _segundoRestantes = TEMPO_POR_CATEGORIA;
            lblTempo.Text = $"{_segundoRestantes}";
            lblTempo.ForeColor = System.Drawing.Color.Green;
            timerPergunta.Start();
        }

        private void PararTempo()
        {
            timerPergunta.Stop();
        }

        private void timerPergunta_Tick(object sender, EventArgs e)
        {
            _segundoRestantes--;
            lblTempo.Text = $"{_segundoRestantes}";

            if (_segundoRestantes <= 5)
                lblTempo.ForeColor = System.Drawing.Color.Red;
            else if (_segundoRestantes <= 10)
                lblTempo.ForeColor = System.Drawing.Color.Orange;

            if (_segundoRestantes <= 0)
            {
                PararTempo();
                lblExplicacao.Text = " Tempo esgotado! " + (_jogo.PerguntaAtual()?.Explicacao ?? "");
                _jogo.Responder(false);
                AtualizarTela();
            }
        }

        // preenche as opções de categoria na comboBox
        private void ConfigurarComboBox()
        {
            cbxCategoria.Items.AddRange(new string[]
            { "Todas", "Tecnologia", "IA", "Saúde", "Redes Sociais", "Política" });

            cbxCategoria.SelectedIndex = 0;
        }

        // Botão de INICIAR: inicializa um novo jogo e exibe a tela
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string categoria = cbxCategoria.SelectedItem?.ToString() ?? "Todas";
            _jogo = new Jogo(categoria);
            lblExplicacao.Text = "";
            AtualizarTela();
        }

        // Botão FAKE: jogador acredita que a resposta é uma mentira
        private void btnFake_Click(object sender, EventArgs e) // CORRIGIDO: nome padrão do designer
        {
            ProcessarResposta(false);
        }

        // Botão FACT: jogador acredita que a resposta é uma verdade
        private void btnFact_Click(object sender, EventArgs e) // CORRIGIDO: nome padrão do designer
        {
            ProcessarResposta(true);
        }

        // Processa a resposta e atualiza a tela
        private void ProcessarResposta(bool resposta)
        {
            if (_jogo == null || _jogo.JogoEncerrado)
                return;

            string explicacao = _jogo.PerguntaAtual()?.Explicacao ?? "Fim de jogo!";
            bool acertou = _jogo.Responder(resposta);

            lblExplicacao.Text = acertou ? "✅ Correto! " : "❌ Errado! ";
            lblExplicacao.Text += explicacao;

            AtualizarTela();
        }

        // Atualiza todos os elementos visuais da tela
        private void AtualizarTela()
        {
            PararTempo();
            if (_jogo == null)
                return;

            lblPontuacao.Text = $"Pontuação: {_jogo.Pontuacao}";

            if (_jogo.JogoEncerrado)
            {
                lblPergunta.Text = $"Fim! Sua pontuação final: {_jogo.Pontuacao} pontos";
                btnFake.Enabled = false; // CORRIGIDO: referencia o controle, não o método
                btnFact.Enabled = false;
                return;
            }

            Pergunta atual = _jogo.PerguntaAtual()!;
            lblPergunta.Text  = atual.Enunciado;
            lblProgresso.Text = $"Pergunta {_jogo.IndiceAtual + 1} de {_jogo.TotalPerguntas}";
            btnFake.Enabled   = true;
            btnFact.Enabled   = true;
            IniciarTimer();
        }
    }
}