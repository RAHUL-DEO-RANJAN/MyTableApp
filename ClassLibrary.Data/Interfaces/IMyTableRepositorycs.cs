using ClassLibrary.Data.Entities;

namespace ClassLibrary.Data.Interfaces
{
    public interface IMyTableRepository
    {
        Task<IEnumerable<MyTable>> GetAll();
        Task<MyTable> Add(MyTable client);
        Task<MyTable> Update(MyTable client);
        Task<MyTable> Delete(int id);
        Task<MyTable> GetById(int id);
    }
}
