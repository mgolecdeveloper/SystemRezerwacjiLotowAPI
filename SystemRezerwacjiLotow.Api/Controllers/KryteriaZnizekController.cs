using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SystemRezerwacjiLotow.Application.Abstractions;
using SystemRezerwacjiLotow.Domain.Models;
using SystemRezerwacjiLotow.Domain.DTOs;
using SystemRezerwacjiLotow.Domain.DTOs.KryteriaZnizek;
using SystemRezerwacjiLotow.Domain.DTOs.Tenants;
using SystemRezerwacjiLotow.Infrastruktura.Abstractions;

namespace SystemRezerwacjiLotow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KryteriaZnizekController : ControllerBase
    {
        private readonly IKryteriaZnizekRepository _kryteriaZnizekRepository;

        public KryteriaZnizekController(IKryteriaZnizekRepository kryteriaZnizekRepository)
        {
            _kryteriaZnizekRepository = kryteriaZnizekRepository;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<KryteriaZnizki>>> GetKryteriaZnizek()
        {
            try
            {
                var result = await _kryteriaZnizekRepository.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<KryteriaZnizki>> GetKryteriaZnizki(string id)
        {
            try
            {
                var result = await _kryteriaZnizekRepository.Get(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<KryteriaZnizkiDto>> PostKryteriaZnizki(KryteriaZnizkiDto model)
        {
            try
            {
                var result = await _kryteriaZnizekRepository.Create(model);
                return CreatedAtAction(nameof(GetKryteriaZnizki), new { id = model.KryteriaZnizkiId }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpPut("{id}")]
        public async Task<ActionResult<KryteriaZnizkiDto>> PutKryteriaZnizki(string id, KryteriaZnizkiDto model)
        {
            try
            {
                if (id != model.KryteriaZnizkiId)
                    return BadRequest("Id mismatch");

                var result = await _kryteriaZnizekRepository.Update(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteResult>> DeleteKryteriaZnizki(string id)
        {
            try
            {
                var result = await _kryteriaZnizekRepository.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
