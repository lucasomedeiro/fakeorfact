namespace FakeOrFact
{
    public class Jogo
    {
        public int Pontuacao { get; set; }
        public int IndiceAtual { get; set; }
        public int TotalPerguntas { get; set; }
        public bool JogoEncerrado { get; set; }

        private List<Pergunta> _perguntas;

        public Jogo(string categoriaSelecionada = "Todas")
        {
            if (categoriaSelecionada == "Todas")
                _perguntas = BancoPergunta.TodasPerguntas.OrderBy(p => System.Guid.NewGuid()).Take(10).ToList();
            else
                _perguntas = BancoPergunta.TodasPerguntas.Where(p => p.Categoria == categoriaSelecionada)
                                            .OrderBy(p => System.Guid.NewGuid())
                                            .Take(10)
                                            .ToList();
        }
    }
}