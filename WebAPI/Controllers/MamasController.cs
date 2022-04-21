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
    public class MamasController : ControllerBase
    {
        IMamaService _mamaService;

        public MamasController(IMamaService mamaService)
        {
            _mamaService = mamaService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _mamaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Mama mama)
        {
            var result = _mamaService.Add(mama);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Mama mama)
        {
            var result = _mamaService.Update(mama);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Mama mama)
        {
            var result = _mamaService.Delete(mama);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
