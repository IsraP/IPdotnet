namespace IsraConstruct.domain{

    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);

        void Save(TEntity entity);
    }
}