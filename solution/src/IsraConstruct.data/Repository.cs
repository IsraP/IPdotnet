using System.Linq;
using IsraConstruct.domain;

namespace IsraConstruct.data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity{
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context){
            _context = context;
        }

        public TEntity GetById(int id){

            // var query =_context.Set<TEntity>().SingleOrDefault(e => e.Id == id);
            // if(query.Any())
            //     return query.First();
            // return null;
            
            return _context.Set<TEntity>().SingleOrDefault(e => e.Id == id);
        }

        public void Save(TEntity entity){
            _context.Set<TEntity>().Add(entity);
            
            _context.SaveChanges();
        }
    }
}