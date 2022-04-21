using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HekimsController : ControllerBase
    {
        IHekimService _hekimService;

        public HekimsController(IHekimService hekimService)
        {
            _hekimService = hekimService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _hekimService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Hekim hekim)
        {
            var result = _hekimService.Add(hekim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Hekim hekim)
        {
            var result = _hekimService.Update(hekim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Hekim hekim)
        {
            var result = _hekimService.Delete(hekim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
