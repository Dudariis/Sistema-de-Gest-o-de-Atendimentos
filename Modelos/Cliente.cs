using System;

namespace helpdesk;

// + Class Cliente
public class Cliente : Usuario
{
    public Cliente(int id, string nome, string email, string senha) : base(id, nome, email, senha)
    {
    }

    // + AbrirChamado() : void
    public void AbrirChamado()
    {
        Console.WriteLine("Chamado aberto com sucesso.");
    }

    // + VisualizarStatus() : void
    public override void VisualizarStatus()
    {
        Console.WriteLine("Cliente visualizando o status do chamado.");
    }
}