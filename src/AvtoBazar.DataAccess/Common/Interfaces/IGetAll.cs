using AvtoBazar.DataAccess.Utils;

namespace AvtoBazar.DataAccess.Common.Interfaces;

public interface IGetAll<TModel>
{
    public Task<IList<TModel>> GetAllAsync(PaginationParams @params);
    //public Task<IList<TModel>> GetAllAsync(PaginationParams @params);
}
