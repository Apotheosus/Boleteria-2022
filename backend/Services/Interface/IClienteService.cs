using BoleteriaOnline.Web.Utils;
using BoleteriaOnline.Web.ViewModels.Requests;
using BoleteriaOnline.Web.ViewModels.Responses;

namespace BoleteriaOnline.Web.Services.Interface;
public interface IClienteService
{
    Task<WebResult<ICollection<ClienteResponse>>> GetClientesAsync();
    Task<WebResult<ClienteResponse>> GetClienteAsync(long id);
    Task<WebResult<ClienteResponse>> CreateClienteAsync(ClienteRequest clienteDto);
    Task<WebResult<ClienteResponse>> UpdateClienteAsync(ClienteRequest clienteDto);
    Task<WebResult<ClienteResponse>> DeleteClienteAsync(long id);
}
