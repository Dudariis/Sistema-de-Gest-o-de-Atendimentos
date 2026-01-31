using System;

namespace HelpDesk;

public class HistoricoChamado
{
    public DateTime Data { get, set; }
    public string Descricao { get, set; }

    public HistoricoChamado(string descricao)
    {
        Data = DateTime.Now;
        Descricao = descricao;
    }
}