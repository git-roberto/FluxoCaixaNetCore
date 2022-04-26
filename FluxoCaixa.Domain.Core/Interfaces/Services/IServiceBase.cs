using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        T Buscar(int id);

        IEnumerable<T> Listar();

        void Inserir(T registro);

        void Atualizar(T registro);

        void Excluir(T registro);

        void Dispose();
    }
}
