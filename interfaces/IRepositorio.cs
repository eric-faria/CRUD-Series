using System.Collections.Generic;

namespace CRUD_Series.interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId (int Id);
        void Insere (T Entidade);
        void Exclui (int Id);
        void Atualiza (int Id, T Entidade);
        int ProximoId();

    }
}