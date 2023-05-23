using ApiTreinoNutricao.Data.Context;
using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto.Enum;
using ApiTreinoNutricao.Domain.Entities;
using ApiTreinoNutricao.Domain.Interfaces.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ApiTreinoNutricao.Data.Repositories.Common
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApiBaseContext _apiBaseContext;

        public BaseRepository(ApiBaseContext apiBaseContext)
        {
            _apiBaseContext = apiBaseContext;
        }

        public virtual void Delete(long id)
        {
            _apiBaseContext.Set<TEntity>().Remove(Find(id));
            _apiBaseContext.SaveChanges();
        }

        public virtual TEntity Find(long id) => _apiBaseContext.Set<TEntity>().Find(id);

        public virtual IEnumerable<TEntity> GetAll() => _apiBaseContext.Set<TEntity>().AsEnumerable();

        public virtual TEntity Insert(TEntity entity)
        {
            entity.Ativo = true;
            entity.DataCadastro = DateTime.Now;

            var retorno = _apiBaseContext.Set<TEntity>().Add(entity).Entity;
            _apiBaseContext.SaveChanges();

            return retorno;
        }

        public virtual void Update(TEntity entity)
        {
            _apiBaseContext.Entry(entity).State = EntityState.Modified;
            _apiBaseContext.SaveChanges();
        }

        public virtual void UpdateWithRule(TEntity entity, IList<string>? camposExcluir = null)
        {
            var camposExcluidos = new List<string>()
            {
                "Id", "DataCadastro"
            };

            if (camposExcluir != null)
                camposExcluidos.AddRange(camposExcluir);

            foreach (PropertyInfo property in entity.GetType().GetProperties())
                if (!camposExcluidos.Contains(property.Name) && !property.GetMethod.IsVirtual)
                    _apiBaseContext.Entry(entity).Property(property.Name).IsModified = true;

            _apiBaseContext.SaveChanges();
        }

        public virtual IQueryable<TEntity> GetByAtivoInativo(IQueryable<TEntity> query, BuscarUsuarioEnum tipoBusca)
        {
            return tipoBusca switch
            {
                BuscarUsuarioEnum.Ativos => query.Where(x => x.Ativo == true),
                BuscarUsuarioEnum.Inativos => query.Where(x => x.Ativo == false),
                BuscarUsuarioEnum.Todos => query,
                _ => query
            };
        }
    }
}
