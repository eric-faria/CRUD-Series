using System;

namespace CRUD_Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;}

        public Serie (int Id, Genero Genero, string Titulo, string Descricao, int Ano )
        {
            this.Id = Id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao; 
            this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string Retorno = "";
            Retorno += "Genero: " + this.Genero + Environment.NewLine;
            Retorno += "Titulo: " + this.Titulo + Environment.NewLine; 
            Retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            Retorno += "Ano: " + this.Ano + Environment.NewLine;
            Retorno += "Excluído: " + this.Excluido;
            return Retorno;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaID()
        {
            return this.Id;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}