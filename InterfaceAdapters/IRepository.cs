using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetExperience.InterfaceAdapters
{
    public interface IRepository<IEntity>
    {
        Task<List<IEntity>> GetAll();
        Task<IEntity> Get(int id);
        Task<IEntity> Add(IEntity entity);
        Task<IEntity> Update(IEntity entity);
        Task<IEntity> Delete(int id);
    }
}
