using Microsoft.AspNetCore.Mvc;
using ReyNenePalace.Models;
using System.Collections.Generic;
using System.Linq;

namespace ReyNenePalace.Contollers.API
{
    [Route("api/pie")]
    public class PieApiController: ControllerBase
    {
        private readonly IPieRepository _pieRepository;
       
        public PieApiController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository; 
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pie>> GetPies()
        {
            return Ok(_pieRepository.AllPies);
        }
    }
}
