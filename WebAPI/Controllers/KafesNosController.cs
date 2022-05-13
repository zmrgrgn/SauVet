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
    public class KafesNosController : ControllerBase
    {
        IKafesNoService _kafesNoService;
        public KafesNosController(IKafesNoService kafesNoService)
        {
            _kafesNoService = kafesNoService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _kafesNoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(KafesNo kafesNo)
        {
            var result = _kafesNoService.Add(kafesNo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(KafesNo kafesNo)
        {
            var result = _kafesNoService.Update(kafesNo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(KafesNo kafesNo)
        {
            var result = _kafesNoService.Delete(kafesNo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
