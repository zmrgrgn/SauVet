using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HayvanKayitsController : ControllerBase
    {
        IHayvanKayitService _hayvanKayitService;

        public HayvanKayitsController(IHayvanKayitService hayvanKayitService)
        {
            _hayvanKayitService = hayvanKayitService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            
            var result = _hayvanKayitService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(string hayvanKayitId)
        {

            var result = _hayvanKayitService.GetById(hayvanKayitId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(HayvanKayit hayvanKayit)
        {
            var result = _hayvanKayitService.Add(hayvanKayit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(HayvanKayit hayvanKayit)
        {
            var result = _hayvanKayitService.Update(hayvanKayit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(HayvanKayit hayvanKayit)
        {
            var result = _hayvanKayitService.Delete(hayvanKayit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
