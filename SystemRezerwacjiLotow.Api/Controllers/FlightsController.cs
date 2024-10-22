using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SystemRezerwacjiLotow.Domain.Models;
using SystemRezerwacjiLotow.Domain.DTOs;
using SystemRezerwacjiLotow.Domain.DTOs.Flights;
using SystemRezerwacjiLotow.Infrastruktura.Abstractions;

namespace SystemRezerwacjiLotow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightsRepository _flightsRepository;

        public FlightsController(IFlightsRepository flightsRepository)
        {
            _flightsRepository = flightsRepository;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<Flight>>> GetFlights()
        {
            try
            {
                var result = await _flightsRepository.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlight(string id)
        {
            try
            {
                var result = await _flightsRepository.Get(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<FlightDto>> PostFlight(FlightDto model)
        {
            try
            {
                var result = await _flightsRepository.Create(model);
                return CreatedAtAction(nameof(GetFlight), new { id = model.FlightId }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpPut("{id}")]
        public async Task<ActionResult<FlightDto>> PutFlight(string id, FlightDto model)
        {
            try
            {
                if (id != model.FlightId)
                    return BadRequest("Id mismatch");

                var result = await _flightsRepository.Update(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteResult>> DeleteFlight(string id)
        {
            try
            {
                var result = await _flightsRepository.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }
}
