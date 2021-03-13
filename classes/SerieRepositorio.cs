using System;
using System.Collections.Generic;
using CRUD_Series.interfaces;

namespace CRUD_Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSeries = new List<Serie>();
        public void Atualiza(int Id, Serie Objeto)
        {
            ListaSeries[Id] = Objeto;
        }

        public void Exclui(int Id)
        {
            ListaSeries[Id].Excluir();
        }

        public void Insere(Serie Entidade)
        {
            ListaSeries.Add(Entidade);
        }

        public List<Serie> Lista()
        {
            return ListaSeries;
        }

        public int ProximoId()
        {
            return ListaSeries.Count;
        }

        public Serie RetornaPorId(int Id)
        {
            return ListaSeries[Id];
        }
    }
}