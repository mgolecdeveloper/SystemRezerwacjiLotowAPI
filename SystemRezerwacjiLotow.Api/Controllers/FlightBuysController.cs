using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SystemRezerwacjiLotow.Domain.Models;
using SystemRezerwacjiLotow.Domain.DTOs;
using SystemRezerwacjiLotow.Domain.DTOs.FlightBuys;
using SystemRezerwacjiLotow.Infrastruktura.Abstractions;

namespace SystemRezerwacjiLotow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightBuysController : ControllerBase
    {
        private readonly IFlightBuysRepository _flightBuysRepository;

        public FlightBuysController(IFlightBuysRepository flightBuysRepository)
        {
            _flightBuysRepository = flightBuysRepository;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<FlightBuy>>> GetFlightBuys()
        {
            try
            {
                var result = await _flightBuysRepository.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<FlightBuy>> GetFlightBuy(string id)
        {
            try
            {
                var result = await _flightBuysRepository.Get(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<FlightBuyDto>> PostFlightBuy(FlightBuyDto model)
        {
            try
            {
                var result = await _flightBuysRepository.Create(model);
                return CreatedAtAction(nameof(GetFlightBuy), new { id = model.FlightBuyId }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpPut("{id}")]
        public async Task<ActionResult<FlightBuyDto>> PutFlightBuy(string id, FlightBuyDto model)
        {
            try
            {
                if (id != model.FlightBuyId)
                    return BadRequest("Id mismatch");

                var result = await _flightBuysRepository.Update(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteResult>> DeleteFlightBuy(string id)
        {
            try
            {
                var result = await _flightBuysRepository.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
