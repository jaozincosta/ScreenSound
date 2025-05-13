using System.Collections.Generic;

class Episodio
{
    private List<string> convidados = new();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }

    public string Titulo { get; }

    public int Duracao { get; }

    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - Convidados: {string.Join(", ", convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}
