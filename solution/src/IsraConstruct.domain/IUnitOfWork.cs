using System.Threading.Tasks;

namespace IsraConstruct.domain{
    public interface IUnitOfWork{
        Task Commit();
    }
}