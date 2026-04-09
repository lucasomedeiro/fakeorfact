using System.Collections.Generic;

namespace FakeOrFact
{
    public static List<Pergunta> TodasPerguntas = new List<Pergunta>()
    {
        // Questões de categoria Tecnologia
        new Pergunta(
            enunciado: "O primeiro computador pessoal foi lançado pela Apple em 1976.",
            efato: true,
            explicacao: "O Apple I foi lançado em 1976 por Steve Worniak e Steve Jobs.",
            categoria: "Tecnologia"
        ),
        new Pergunta(
            enunciado: "A internet e a Web são a mesma coisa.",
            efato: false,
            explicacao: "A internet é a infraestrutura global de redes; a Web é um serviço que funciona sobre ela.",
            categoria: "Tecnologia"
        ),
        new Pergunta(
            enunciado: "O sistema Operacional gerencia o hardware e os softwares do computador.",
            efato: true,
            explicacao: "Ele é quem controla memória, processador, arquivos e permite a execução de programas.",
            categoria: "Tecnologia"
        ),
        new Pergunta(
            enunciado: "O vírus de computador sempre danifica fisicamente o hardware.",
            efato: false,
            explicacao: "Vírus afetam principalmente softwares e dados, não o hardware físico.",
            categoria: "Tecnologia"
        ),
        new Pergunta(
            enunciado: "A computação em nuvem permite acessar arquivos pela internet sem depender do armazenamento local.",
            efato: true,
            explicacao: "Serviços na nuvem armazenam dados em servidores remotos acessíveis online.",
            categoria: "Tecnologia"
        ),

        // Questões de categoria IA
        new Pergunta(
            enunciado: "A IA consegue sentir emoções como tristeza e alegria.",
            efato: false,
            explicacao: "IAs simulam padrões, mas não têm consciência nem emoções reais.",
            categoria: "IA"
        ),
        new Pergunta(
            enunciado: "A Inteligência Artificial Geral já é uma realidade comum no mercado atual.",
            efato: false,
            explicacao: "Atualmente vivemos na era da IA Restrita, que seria uma máquina capaz de realizar qualquer tarefa intelectual humana.",
            categoria: "IA"
        ),
        new Pergunta(
            enunciado: "Redes Neurais Artificiais são inspiradas na estrutura biológica do cerébro humano.",
            efato: true,
            explicacao: "Elas tentam mimetizar a forma como os neurônios se comunicam para processar informações e aprender padrões.",
            categoria: "IA"
        ),
        new Pergunta(
            enunciado: "Machine Learning é um subcampo da Inteligência Artificial",
            efato: true,
            explicacao: "Todo Machine Learning é IA, mas nem toda IA é Machine Learning.",
            categoria: "IA"
        ),
        new Pergunta(
            enunciado: "Modelo de Linguagem de Grande Escala LLMs possuem consciência e sentimentos.",
            efato: false,
            explicacao: "Eles são modelos estatísticos avançados que preveem a próxima palavra com base em padrões de dados, sem possuir subjetividade ou emoções.",
            categoria: "IA"
        ),

        // Questões de categoria Redes Sociais
        new Pergunta(
            enunciado: "Redes Sociais e mídias sociais são termos sinônimos e significam exatamente a mesma coisa.",
            efato: false,
            explicacao: "Redes Sociais referem-se às conexões entre pessoas, enquanto mídias sociais são as plataformas e ferramentas que permitem a criação e o compartilhamento de conteúdo.",
            categoria: "Redes Sociais"
        ),
        new Pergunta(
            enunciado: "O algoritmo de uma rede social determina qual conteúdo será exibido para cada usuário.",
            efato: true,
            explicacao: "Os algoritmos analisam o comportamento do usuário para priorizar postagens que tenham maior probabilidade de gerar engajamento.",
            categoria: "Redes Sociais"
        ),
    };
}