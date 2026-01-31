using System;
using helpdesk;

namespace HelpDesk;

public class Chamado : IAtribuivel : IEncerravel
{
    public int Id { get, set; }
    public string Titulo { get, set; }
    public Cliente Cliente { get, set; }
    public Tecnico Tecnico { get, set; }
    public bool Encerrado { get, set; }

    public List<HistoricoChamado> Historico { get, set; }

    public Chamado(int id, string titulo, Cliente cliente)
    {
        Id = id;
        Titulo = titulo;
        Cliente = cliente;
        Encerrado = false;
        Historico = new List<HistoricoChamado>(); 
    }

    public void AtribuirTecnico(Tecnico tecnico)
    {
        Tecnico = tecnico;
        Historico.Add(new HistoricoChamado("Técnico atríbuido ao chamado."));
    }

    public void Encerrar()
    {
        Encerrado = true;
        Historico.Add(new HistoricoChamado("Chamado Encerrado."));
    }
}