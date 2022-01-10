using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicKindsController : ControllerBase
    {
        private IMusicKindService _musicKindService;

        public MusicKindsController(IMusicKindService musicKindService)
        {
            _musicKindService = musicKindService;
        }

        [HttpPost("add")]
        public IActionResult Add(MusicKind kind)
        {
            var result = _musicKindService.Add(kind);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_musicKindService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
