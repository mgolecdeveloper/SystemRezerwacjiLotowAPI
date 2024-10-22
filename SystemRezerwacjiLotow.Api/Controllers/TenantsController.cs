using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SystemRezerwacjiLotow.Application.Abstractions;
using SystemRezerwacjiLotow.Domain.Models;
using SystemRezerwacjiLotow.Domain.DTOs;
using SystemRezerwacjiLotow.Domain.DTOs.Tenants;

namespace SystemRezerwacjiLotow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantsController : ControllerBase
    {
        private readonly ITenantsService _tenantsService;

        public TenantsController(ITenantsService tenantsService)
        {
            _tenantsService = tenantsService;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<Tenant>>> GetTenants()
        {
            try
            {
                var result = await _tenantsService.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<Tenant>> GetTenant(string id)
        {
            try
            {
                var result = await _tenantsService.GetTenantById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<TenantDto>> PostTenant(TenantDto model)
        {
            try
            {
                var result = await _tenantsService.Create(model);
                return CreatedAtAction(nameof(GetTenant), new { id = model.Id }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpPut("{id}")]
        public async Task<ActionResult<TenantDto>> PutTenant(string id, TenantDto model)
        {
            try
            {
                if (id != model.Id)
                    return BadRequest("Id mismatch");

                var result = await _tenantsService.Update(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [AllowAnonymous]
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteResult>> DeleteTenant(string id)
        {
            try
            {
                var result = await _tenantsService.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
