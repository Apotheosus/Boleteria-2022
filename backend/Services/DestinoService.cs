using AutoMapper;
using BoleteriaOnline.Web.Data.Models;
using BoleteriaOnline.Web.Data.Models.Enums;
using BoleteriaOnline.Web.Extensions.Response;
using BoleteriaOnline.Web.Repository.Interface;
using BoleteriaOnline.Web.Services.Interface;
using BoleteriaOnline.Web.Utils;
using BoleteriaOnline.Web.ViewModels.Requests;
using BoleteriaOnline.Web.ViewModels.Responses;
using EntityFramework.Exceptions.Common;

namespace BoleteriaOnline.Web.Services;
using static WebResponse;
public class DestinoService : IDestinoService
{
    private readonly IMapper _mapper;
    private readonly IDestinoRepository _destinoRepository;

    public DestinoService(IMapper mapper, IDestinoRepository destinoRepository)
    {
        _mapper = mapper;
        _destinoRepository = destinoRepository;
    }

    public async Task<WebResult<DestinoResponse>> CreateDestinoAsync(DestinoRequest destinoDto)
    {
        try
        {
            if (await _destinoRepository.ExistsDestinoAsync(destinoDto.Id))
                return Error<Destino, DestinoResponse>(ErrorMessage.AlreadyExists);

            var destino = _mapper.Map<Destino>(destinoDto);
            if (!await _destinoRepository.CreateDestinoAsync(destino))
                return Error<Destino, DestinoResponse>(ErrorMessage.CouldNotCreate);

            var dto = _mapper.Map<DestinoResponse>(destino);
            return Ok<Destino, DestinoResponse>(dto, SuccessMessage.Created);
        }
        catch (UniqueConstraintException)
        {
            return Error<Destino, DestinoResponse>(ErrorMessage.AlreadyExists);
        }
        catch (Exception ex)
        {
            return Error<Destino, DestinoResponse>(ErrorMessage.Generic, ex.Message);
        }
    }
    public async Task<WebResult<DestinoResponse>> DeleteDestinoAsync(long id)
    {
        try
        {
            var destino = await _destinoRepository.GetDestinoAsync(id);
            if (destino == null)
                return Error<Destino, DestinoResponse>(ErrorMessage.NotFound);

            if (destino.Estado == Estado.BAJA)
                return Error<Destino, DestinoResponse>(ErrorMessage.AlreadyDeleted);

            if (!await _destinoRepository.DeleteDestinoAsync(destino))
                return Error<Destino, DestinoResponse>(ErrorMessage.CouldNotDelete);

            return Ok<Destino, DestinoResponse>(_mapper.Map<DestinoResponse>(destino), SuccessMessage.Deleted);
        }
        catch (Exception ex)
        {
            return Error<Destino, DestinoResponse>(ErrorMessage.Generic, ex.Message);
        }
    }
    public async Task<WebResult<DestinoResponse>> GetDestinoAsync(long id)
    {
        try
        {
            var destino = await _destinoRepository.GetDestinoAsync(id);

            if (destino == null)
                return Error<Destino, DestinoResponse>(ErrorMessage.NotFound);

            return Ok(_mapper.Map<DestinoResponse>(destino));
        }
        catch (Exception ex)
        {
            return Error<Destino, DestinoResponse>(ErrorMessage.Generic, ex.Message);
        }
    }
    public async Task<WebResult<ICollection<DestinoResponse>>> GetDestinosAsync()
    {
        try
        {
            var destinos = await _destinoRepository.GetDestinosAsync();

            var destinosDto = new List<DestinoResponse>();

            foreach (var Destino in destinos)
            {
                destinosDto.Add(_mapper.Map<DestinoResponse>(Destino));
            }
            return Ok<ICollection<DestinoResponse>>(destinosDto);
        }
        catch (Exception ex)
        {
            return Error<Destino, ICollection<DestinoResponse>>(ErrorMessage.Generic, ex.Message);
        }
    }

    public async Task<WebResult<DestinoResponse>> UpdateDestinoAsync(DestinoRequest destinoDto)
    {
        try
        {
            if (destinoDto.Id == 0)
                return Error<Destino, DestinoResponse>(ErrorMessage.InvalidId);

            var destino = await _destinoRepository.GetDestinoAsync(destinoDto.Id);

            if (destino == null)
                return Error<Destino, DestinoResponse>(ErrorMessage.NotFound);

            destino.Nombre = destinoDto.Nombre;

            if (!await _destinoRepository.UpdateDestinoAsync(destino))
                return Error<Destino, DestinoResponse>(ErrorMessage.CouldNotUpdate);

            return Ok<Destino, DestinoResponse>(_mapper.Map<DestinoResponse>(destino), SuccessMessage.Modified);
        }
        catch (Exception ex)
        {
            return Error<Destino, DestinoResponse>(ErrorMessage.Generic, ex.Message);
        }
    }
}
