using ClassLibrary.Service.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Service.Interfaces
{
    public interface IHomeService
    {
        Task<Response> GetRecord(int id);
        Task<Response> AddRecord(AddMyTableViewModel model);
        Task<Response> UpdateRecord(UpdateMyTableViewModel model);
        Task<Response> DeleteRecord(int id);
    }
}
