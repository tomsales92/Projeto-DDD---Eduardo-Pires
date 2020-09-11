using ModeloDDD.Application.Interface;
using ModeloDDD.Domain.Entities;
using ModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ModeloDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            :base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarProNome(string nome)
        {
            throw new System.NotImplementedException();
        }
    }
}
