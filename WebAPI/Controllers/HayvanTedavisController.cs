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
    public class HayvanTedavisController : ControllerBase
    {
        IHayvanTedaviService _hayvanTedaviService;

        public HayvanTedavisController(IHayvanTedaviService hayvanTedaviService)
        {
            _hayvanTedaviService = hayvanTedaviService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _hayvanTedaviService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(HayvanTedavi hayvanTedavi)
        {
            var result = _hayvanTedaviService.Add(hayvanTedavi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(HayvanTedavi hayvanTedavi)
        {
            var result = _hayvanTedaviService.Update(hayvanTedavi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(HayvanTedavi hayvanTedavi)
        {
            var result = _hayvanTedaviService.Delete(hayvanTedavi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
