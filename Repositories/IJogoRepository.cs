using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CatalogoDeJogos.Entities;

namespace CatalogoDeJogos.Repositories
{
    public interface IJogoRepository
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid id);
        Task<List<Jogo>> Inserir(string nome, string produtora);

        Task Inserir(Jogo jogo);
        Task Atualizar(Jogo jogo);

        Task Remover(Guid id);

    }
}