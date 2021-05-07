﻿using Caixa.Domain;
using System.Collections.Generic;

namespace Caixa.Data.Interface
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        void Incluir(T entity);
        void Alterar(T entity);
        T Selecionar(int id);
        List<T> SelecionarTudo();
        void Excluir(int id);
        void Dispose();
    }
}
