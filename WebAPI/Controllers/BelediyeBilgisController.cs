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
    public class BelediyeBilgisController : ControllerBase
    {
        IBelediyeBilgiService _belediyeBilgiService;

        public BelediyeBilgisController(IBelediyeBilgiService belediyeBilgiService)
        {
            _belediyeBilgiService = belediyeBilgiService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _belediyeBilgiService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(BelediyeBilgi belediyeBilgi)
        {
            var result = _belediyeBilgiService.Add(belediyeBilgi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(BelediyeBilgi belediyeBilgi)
        {
            var result = _belediyeBilgiService.Update(belediyeBilgi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(BelediyeBilgi belediyeBilgi)
        {
            var result = _belediyeBilgiService.Delete(belediyeBilgi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
