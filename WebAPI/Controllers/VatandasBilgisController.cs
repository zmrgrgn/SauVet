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
    public class VatandasBilgisController : ControllerBase
    {
        IVatandasBilgiService _vatandasBilgiService;

        public VatandasBilgisController(IVatandasBilgiService vatandasBilgiService)
        {
            _vatandasBilgiService = vatandasBilgiService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _vatandasBilgiService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(VatandasBilgi vatandasBilgi)
        {
            var result = _vatandasBilgiService.Add(vatandasBilgi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(VatandasBilgi vatandasBilgi)
        {
            var result = _vatandasBilgiService.Update(vatandasBilgi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(VatandasBilgi vatandasBilgi)
        {
            var result = _vatandasBilgiService.Delete(vatandasBilgi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
