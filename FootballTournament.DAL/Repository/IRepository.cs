using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTournament.DAL.Architecture
{
    public interface IRepository
    {
        TEntity? GetById<TEntity>(int id) where TEntity : class;

        void Add(object standings);
        void Update(object standings);
        void Delete(object standings);
        public List<TEntity> GetAll<TEntity>() where TEntity : class;
    }
}
