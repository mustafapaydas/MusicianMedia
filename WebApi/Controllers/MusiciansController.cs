using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        private IMusicianService _musicianService;

        public MusiciansController(IMusicianService musicianService)
        {
            _musicianService=musicianService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _musicianService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]

        public IActionResult Add(Musician musician)
        {
            var result = _musicianService.Add(musician);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Delete")]

        public IActionResult Delete(Musician musician)
        {
            var result = _musicianService.Delete(musician);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("Update")]

        public IActionResult Update(Musician musician)
        {
            var result = _musicianService.Update(musician);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int musicianId)
        {
            var result = _musicianService.GetById(musicianId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
    }
}
