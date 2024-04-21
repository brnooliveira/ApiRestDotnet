using ApiRestUdemy.Data;
using ApiRestUdemy.Models;
using ApiRestUdemy.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestUdemy.Controllers
{
    [Route("api/VillaApi")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {
            return VillaStore.villaList;
        }

        [HttpGet("{id:int}")]
        public VillaDto GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(x => x.Id == id);
        }

    }
}
