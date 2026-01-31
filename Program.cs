using System;
using helpdesk;

namespace HelpDesk;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente(1, "Duda");
        Tecnico tecnico = new Tecnico(2, "Evelyn");

        Chamado chamado = new Chamado(100, "Erro no sistema", cliente);

        chamado.AtribuirTecnico(tecnico);
        chamado.Encerrar();

        Console.WriteLine("Chamado criado com sucesso.");
        Console.WriteLine($"Cliente: {cliente.Nome}");
        Console.WriteLine($"Técnico: {tecnico.Nome}");
        Console.WriteLine($"Encerrado: {chamado.Encerrado}");

        Console.WriteLine("\nHistorico:");
        foreach (var h in chamado.Historico)
        {
            Console.WriteLine($"{h.Data} - {h.Descricao}");
        }
    }
}