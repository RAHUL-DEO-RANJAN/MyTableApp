using ClassLibrary.Service.Interfaces;
using ClassLibrary.Service.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace CRUDWithMsSQL.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpPost("AddRecord")]
        public async Task<ActionResult> AddRecord(AddMyTableViewModel addMyTableViewModel)
        {
            try
            {
                var response = await _homeService.AddRecord(addMyTableViewModel);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("UpdateRecord")]
        public async Task<ActionResult> UpdateRecord(UpdateMyTableViewModel addMyTableViewModel)
        {
            try
            {
                var response = await _homeService.UpdateRecord(addMyTableViewModel);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("DeleteRecord")]
        public async Task<ActionResult> DeleteRecord(int id)
        {
            try
            {
                var response = await _homeService.DeleteRecord(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetRecord")]
        public async Task<ActionResult> GetRecord(int id)
        {
            try
            {
                var response = await _homeService.GetRecord(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
