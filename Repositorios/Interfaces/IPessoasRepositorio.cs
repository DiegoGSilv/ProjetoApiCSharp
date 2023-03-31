using DesafioDev2.Models;

namespace DesafioDev2.Repositorios.Interfaces
{
    public interface IPessoasRepositorio
    {
        Task<List<PessoasModel>> BuscarTodasPessoas();
        Task<PessoasModel> BuscarPorCodigo(int codigo);
        Task<PessoasModel> Adicionar(PessoasModel pessoas);
        Task<PessoasModel> Atualizar(PessoasModel pessoas, int codigo);
        Task<bool> Apagar(int codigo);
       
    }
}
