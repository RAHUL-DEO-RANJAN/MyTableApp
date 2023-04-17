using ClassLibrary.Data.Entities;
using ClassLibrary.Data.Interfaces;
using ClassLibrary.Service.Interfaces;
using ClassLibrary.Service.ViewModels;

namespace ClassLibrary.Service.Services
{
    public class HomeService : IHomeService
    {
        private readonly IMyTableRepository _myTableRepository;
        public HomeService(IMyTableRepository myTableRepository)
        {
            _myTableRepository = myTableRepository;
        }

        public async Task<Response> AddRecord(AddMyTableViewModel model)
        {
            MyTable myTable = new MyTable();
            myTable.FirstName = model.FirstName;
            myTable.LastName = model.LastName;
            myTable.Address = "address";
            var result = await _myTableRepository.Add(myTable);
            return new Response { Data = result };
        }

        public async Task<Response> DeleteRecord(int id)
        {
            var result = await _myTableRepository.Delete(id);
            return new Response { Data = result };
        }

        public async Task<Response> GetRecord(int id)
        {
            var record = await _myTableRepository.GetById(id);
            return new Response { Data = record };
        }

        public async Task<Response> UpdateRecord(UpdateMyTableViewModel model)
        {

            var myTable = await _myTableRepository.GetById(model.Id);
            myTable.FirstName = model.FirstName;
            myTable.LastName = model.LastName;
            myTable.Address = "address";
            var result = await _myTableRepository.Update(myTable);
            return new Response { Data = result };
        }
    }
}
