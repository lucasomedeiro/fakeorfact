using System.Collections.Generic;
using System.Linq;

namespace FakeOrFact
{
    public class Jogo
    {
        public int Pontuacao { get; set; }
        public int IndiceAtual { get; set; }
        public int TotalPerguntas { get; set; }
        public bool JogoEncerrado => IndiceAtual >= TotalPerguntas; 

        private List<Pergunta> _perguntas;

        public Jogo(string categoriaSelecionada = "Todas")
        {
            if (categoriaSelecionada == "Todas")
                _perguntas = BancoPergunta.TodasPerguntas.OrderBy(p => System.Guid.NewGuid()).Take(10).ToList();
            else
                _perguntas = BancoPergunta.TodasPerguntas
                                            .Where(p => p.Categoria == categoriaSelecionada)
                                            .OrderBy(p => System.Guid.NewGuid())
                                            .Take(10)
                                            .ToList();

            TotalPerguntas = _perguntas.Count;
            Pontuacao = 0;
            IndiceAtual = 0;
        }

        public Pergunta? PerguntaAtual()
        {
            if (JogoEncerrado)
                return null;

            return _perguntas[IndiceAtual]; // CORRIGIDO: () virou []
        }

        public bool Responder(bool resposta)
        {
            bool acertou = (resposta == _perguntas[IndiceAtual].Efato);

            if (acertou)
                Pontuacao += 10;

            IndiceAtual++;
            return acertou;
        }
    }
}