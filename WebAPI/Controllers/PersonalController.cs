using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("melisa/app")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        private IPersonalService _personalService;

        public PersonalController(IPersonalService personalService)
        {
            _personalService = personalService;
        }

        [HttpGet("get-all-passive-personals")]
        public List<Personal> Getpassive()
        {
            return _personalService.GetAllPassivePersonals();

        }


        [HttpGet("get-all-personals")]
        public List<Personal> Get()
        {
            return _personalService.GetAllPersonals();
        }

        [HttpPost("add-new-personal")]
        public Personal Add([FromBody] Personal personal)
        {
           return _personalService.CreatePersonal(personal);
        }

        [HttpGet("get-by-id/{id}")]
        public Personal GetById(int id)
        {
           return _personalService.GetPersonalById(id);
        }

        [HttpGet("get-by-title/{title}")]
        public List<Personal> GetByTitle(string title)
        {
            return _personalService.GetPersonalByTitle(title);
        }

        [HttpPut("update-personal")]
        public Personal UpdatePersonal([FromBody] Personal personal)
        {
           return _personalService.UpdatePersonal(personal);
        }

        [HttpDelete("delete")]
        public void DeletePersonal([FromQuery] int id)
        {
            _personalService.DeletePersonal(id);
        }
    }
}
