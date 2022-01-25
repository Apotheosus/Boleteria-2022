using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BoleteriaOnline.Web.Utils;
using BoleteriaOnline.Web.Extensions.Response;
using BoleteriaOnline.Web.Services.Interface;
using BoleteriaOnline.Web.ViewModels.Responses;
using BoleteriaOnline.Web.ViewModels.Requests;

namespace BoleteriaOnline.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ViajesController : ControllerBase
{
    private readonly IViajeService _viajeservice;

    public ViajesController(IViajeService service)
    {
        _viajeservice = service;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WebResult<ICollection<ViajeResponse>>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<WebResult<ICollection<ViajeResponse>>>> GetAll()
    {
        var viajes = await _viajeservice.GetViajesAsync();

        if (!viajes.Success)
            return StatusCode(ResponseHelper.GetHttpError(viajes.ErrorCode), viajes);

        return Ok(viajes);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WebResult<ViajeResponse>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<WebResult<ViajeResponse>>> Get(long id)
    {
        var viaje = await _viajeservice.GetViajeAsync(id);

        if (!viaje.Success)
            return StatusCode(ResponseHelper.GetHttpError(viaje.ErrorCode), viaje);

        return Ok(viaje);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WebResult<ViajeResponse>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<WebResult<ViajeResponse>>> CreateViaje([FromBody] ViajeRequest viajeDto)
    {
        var viaje = await _viajeservice.CreateViajeAsync(viajeDto);

        if (!viaje.Success)
            return StatusCode(ResponseHelper.GetHttpError(viaje.ErrorCode), viaje);
        return Created(nameof(Get), viaje);
    }

    [HttpPatch]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WebResult<ViajeResponse>))]
    public async Task<ActionResult<WebResult<ViajeResponse>>> UpdateViaje([FromBody] ViajeRequest viajeDto)
    {
        var viaje = await _viajeservice.UpdateViajeAsync(viajeDto);

        if (!viaje.Success)
            return StatusCode(ResponseHelper.GetHttpError(viaje.ErrorCode), viaje);
        return Ok(viaje);
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WebResult<ViajeResponse>))]
    public async Task<ActionResult<WebResult<ViajeResponse>>> DeleteViaje(long id)
    {
        var viaje = await _viajeservice.DeleteViajeAsync(id);

        if (!viaje.Success)
            return StatusCode(ResponseHelper.GetHttpError(viaje.ErrorCode), viaje);
        return Ok(viaje);
    }


}
