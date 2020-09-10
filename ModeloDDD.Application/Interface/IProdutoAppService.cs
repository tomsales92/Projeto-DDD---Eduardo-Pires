using ModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ModeloDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarProNome(string nome);
    }
}
