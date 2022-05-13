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
    public class HayvanTursController : ControllerBase
    {
        IHayvanTurService _hayvanTurService;
        public HayvanTursController(IHayvanTurService hayvanTurService)
        {
            _hayvanTurService = hayvanTurService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _hayvanTurService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(HayvanTur hayvanTur)
        {
            var result = _hayvanTurService.Add(hayvanTur);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(HayvanTur hayvanTur)
        {
            var result = _hayvanTurService.Update(hayvanTur);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(HayvanTur hayvanTur)
        {
            var result = _hayvanTurService.Delete(hayvanTur);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
