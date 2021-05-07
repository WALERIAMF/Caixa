using Caixa.Domain;
using System.Collections.Generic;

namespace Caixa.Data.Interface
{
    public interface IBaseService<T> where T : class, IEntity
    {
       
    }
}
