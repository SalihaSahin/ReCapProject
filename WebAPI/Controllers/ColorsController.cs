using Business.Abstract;
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
    public class ColorsController : ControllerBase
    {
        IColorsService _colorsService;

        public ColorsController(IColorsService colorsservice)
        {
            _colorsService = colorsservice;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _colorsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Colors colors)
        {
            var result = _colorsService.Add(colors);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Colors colors)
        {
            var result = _colorsService.Delete(colors);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Colors colors)
        {
            var result = _colorsService.Update(colors);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
