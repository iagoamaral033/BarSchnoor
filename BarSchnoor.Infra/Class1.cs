using Microsoft.EntityFrameworkCore;
using BarSchnoor.Entidades;
using System;

namespace BarSchnoor.Infra.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}

namespace BarSchnoor.Infra.Repositorio
{
    public interface IRepo<T> where T : class
    {
        // minimal interface
        void Add(T entity);
    }

    public class RepoSQLDB<T> : IRepo<T> where T : class
    {
        public void Add(T entity) { }
    }
}
