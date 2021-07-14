using System;
using System.Collections.Generic;
using System.Diagnostics;
using New.Work;

namespace New.Work

public class SimplesRepositorio : IRepositorio<Serie>

{private List<Serie> listaSerie = new List<Serie>();
public void Atualiza(int Id, Serie objeto)
{
    listaSerie[Id] = objeto; 
}
public void Exclui(int Id)
{
    listaSerie[Id].Excluir();
}
public void Insere(Serie entidade)
{ listaSerie.Add(objeto);
}
public List<Serie> Lista()
{ return listaSerie;
}

public int ProximoId()
{ return listaSerie.Count;
}
public Serie RetornaPorId(int Id);
{ return listaSerie[Id];
}
}