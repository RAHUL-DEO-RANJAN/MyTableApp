using ClassLibrary.Data.Entities;
using ClassLibrary.Data.Interfaces;

namespace ClassLibrary.Data.Repositories
{
    public class MyTableRepository : IMyTableRepository
    {
        private readonly IGenericRepository<MyTable> _repository;

        public MyTableRepository(IGenericRepository<MyTable> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<MyTable>> GetAll()
        {
            var result = await _repository.GetAllAsync();
            return result;
        }
        public async Task<MyTable> GetById(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity;
        }

        public async Task<MyTable> Add(MyTable client)
        {
            return await _repository.AddAsync(client);
        }

        public async Task<MyTable> Update(MyTable client)
        {
            return await _repository.UpdateAsync(client);
        }
        public async Task<MyTable> Delete(int id)
        {
            var entity = await GetById(id);
            return await _repository.DeleteAsync(entity);
        }
    }
}
