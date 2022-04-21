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
    public class HayvanSahiplendirmesController : ControllerBase
    {
        IHayvanSahiplendirmeService _hayvanSahiplendirmeService;

        public HayvanSahiplendirmesController(IHayvanSahiplendirmeService hayvanSahiplendirmeService)
        {
            _hayvanSahiplendirmeService = hayvanSahiplendirmeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _hayvanSahiplendirmeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(HayvanSahiplendirme hayvanSahiplendirme)
        {
            var result = _hayvanSahiplendirmeService.Add(hayvanSahiplendirme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(HayvanSahiplendirme hayvanSahiplendirme)
        {
            var result = _hayvanSahiplendirmeService.Update(hayvanSahiplendirme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(HayvanSahiplendirme hayvanSahiplendirme)
        {
            var result = _hayvanSahiplendirmeService.Delete(hayvanSahiplendirme);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
