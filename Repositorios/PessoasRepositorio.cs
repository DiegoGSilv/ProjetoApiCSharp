using DesafioDev2.Data;
using DesafioDev2.Models;
using DesafioDev2.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace DesafioDev2.Repositorios
{
    public class PessoasRepositorio : IPessoasRepositorio
    {
        private readonly SistemaTarefasDBContex _dbContext;
        public PessoasRepositorio(SistemaTarefasDBContex sistemaTarefasDBContex)
        {
            _dbContext = sistemaTarefasDBContex;
        }
        public async Task<PessoasModel> BuscarPorCodigo(int codigo)
        {
            return await _dbContext.Pessoas.FirstOrDefaultAsync(x => x.Codigo == codigo);
        }

        public async Task<List<PessoasModel>> BuscarTodasPessoas()
        {
            return await _dbContext.Pessoas.ToListAsync();
        }
        public async Task<PessoasModel> Adicionar(PessoasModel pessoas)
        {
            
            await _dbContext.Pessoas.AddAsync(pessoas);
            await _dbContext.SaveChangesAsync();

            return pessoas;
        }


        public async Task<PessoasModel> Atualizar(PessoasModel pessoas, int codigo)
        {
            PessoasModel pessoasPorCodigo = await BuscarPorCodigo(codigo);
           
            if(pessoasPorCodigo == null)
            {
                throw new Exception($"Pessoa para o Codigo:{codigo} não foi encontrado no banco de dados.");
            }

            pessoasPorCodigo.Nome = pessoas.Nome;

            _dbContext.Pessoas.Update(pessoasPorCodigo);
            await _dbContext.SaveChangesAsync();

            return pessoasPorCodigo;

        }


        public async Task<bool> Apagar(int codigo)
        {
            PessoasModel pessoasPorCodigo = await BuscarPorCodigo(codigo);

            if (pessoasPorCodigo == null)
            {
                throw new Exception($"Pessoa para o Codigo:{codigo} não foi encontrado no banco de dados.");

            }

            _dbContext.Pessoas.Remove(pessoasPorCodigo);
            await _dbContext.SaveChangesAsync();
            return true;

        }


    }
}
