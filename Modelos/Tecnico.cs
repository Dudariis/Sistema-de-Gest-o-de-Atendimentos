using System;

namespace helpdesk;

public class Tecnico : Usuario
{
    public Tecnico(int id, string nome, string email, string senha) 
    : base(id, nome, email, senha)
    {
    }

    // + MudarStatus() : void
    public void MudarStatus()
    {
        Console.WriteLine("O técnico mudou o status do chamado.");
    }

    // # Matricula() : void
    protected void Matricula()
    {
        Console.WriteLine("Matrícula do técnico registrada.");
    }

    public override void VisualizarStatus()
    {
        Console.WriteLine("Técnico visualizando chamados atribuídos.");
    }

    public string Especialidade { get, private set; }
    public Tecnico(int id, string nome, string email, string senha) : base(id, nome, email, senha)
    {
        Especialidade = Especialidade;
    }

    public override string ExibirDados()
    {
        return $"Técnico: {Nome} - Especialidade {Especialidade}";
    }
}