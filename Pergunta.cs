namespace FakeOrFact
{
    public class Pergunta
    {
        // variável de texto da questão
        public string Enunciado { get; set; }

        // variável de definição de verdadeiro/falso
        public bool Efato { get; set; }

        // explicação a ser exibida para o jogador
        public string Explicacao { get; set; }

        // Categoria das questões
        public string Categoria { get; set; }

        public Pergunta(string enunciado, bool efato, string explicacao, string categoria)
        {
            Enunciado = enunciado;
            Efato = efato;
            Explicacao = explicacao;
            Categoria = categoria;
        }

    }
}