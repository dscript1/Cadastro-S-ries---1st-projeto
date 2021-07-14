namespace Entidade
{
    public class Serie : Entidade
    {
       private Genero Genero {get; set; }

       private string Titulo {get; set; }
       private string Descricao {get; set; }
       
       private int Ano {get; set; }

private bool Excluido {get; set; }
public Serie(int Id, Genero genero, string Titulo, string Descricao, int Ano)

{this.Id = Id;
this.Genero = genero;
this.Titulo = titulo;
this.Descricao = descricao;
this.Ano = ano;
this.Excluido = false;
    }

    public override string ToString()

    {
string retorno = "";
retorno += "Genero: " + this.Genero + Enviroment.NewLine;
retorno += "Titulo: " + this.Titulo + Enviroment.NewLine;
retorno += "Descricao: " + this.Descricao + Enviroment.NewLine;
retorno += "Ano de Inicio: " + this.Ano + Enviroment.NewLine;
retorno += "Excluído: " + this.Excluído;
return retorno; 
}   

public string retornaTitulo()

{ return this.Titulo;}

public int retornaId()

{ return this.Id;}

public void Excluir() {
this.Excluido = true;
}

    }
}