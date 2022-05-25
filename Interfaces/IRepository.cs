using System.Collections.Generic;

namespace DIO.List.Interfaces
{
    public interface IRepository<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}