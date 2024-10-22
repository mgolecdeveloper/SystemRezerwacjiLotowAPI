using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SystemRezerwacjiLotow.Application.Abstractions;
using SystemRezerwacjiLotow.Domain.Models;
using SystemRezerwacjiLotow.Domain.DTOs.Tenants;
using SystemRezerwacjiLotow.Domain.DTOs;
using SystemRezerwacjiLotow.Domain.DTOs.DniWylotow;
using SystemRezerwacjiLotow.Infrastruktura.Abstractions;

namespace SystemRezerwacjiLotow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DniWylotowController : ControllerBase
    {
        private readonly IDniWylotowRepository _dniWylotowRepository;

        public DniWylotowController(IDniWylotowRepository dniWylotowRepository)
        {
            _dniWylotowRepository = dniWylotowRepository;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<DzienWylotu>>> GetDniWylotow()
        {
            try
            {
                var result = await _dniWylotowRepository.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<DzienWylotu>> GetDzienWylotu(string id)
        {
            try
            {
                var result = await _dniWylotowRepository.Get(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<DzienWylotuDto>> PostDzienWylotu(DzienWylotuDto model)
        {
            try
            {
                var result = await _dniWylotowRepository.Create(model);
                return CreatedAtAction(nameof(GetDzienWylotu), new { id = model.DzienWylotuId }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpPut("{id}")]
        public async Task<ActionResult<DzienWylotuDto>> PutDzienWylotu(string id, DzienWylotuDto model)
        {
            try
            {
                if (id != model.DzienWylotuId)
                    return BadRequest("Id mismatch");

                var result = await _dniWylotowRepository.Update(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteResult>> DeleteDzienWylotu(string id)
        {
            try
            {
                var result = await _dniWylotowRepository.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
