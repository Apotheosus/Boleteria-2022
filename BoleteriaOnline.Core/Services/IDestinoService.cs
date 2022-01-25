using BoleteriaOnline.Web.Utils;
using BoleteriaOnline.Web.ViewModels.Requests;
using BoleteriaOnline.Web.ViewModels.Responses;

namespace BoleteriaOnline.Web.Services.Interface;
public interface IDestinoService
{
    Task<WebResult<ICollection<DestinoResponse>>> GetDestinosAsync();
    Task<WebResult<DestinoResponse>> GetDestinoAsync(long id);
    Task<WebResult<DestinoResponse>> CreateDestinoAsync(DestinoRequest destinoDto);
    Task<WebResult<DestinoResponse>> UpdateDestinoAsync(DestinoRequest destinoDto, long id);
    Task<WebResult<DestinoResponse>> DeleteDestinoAsync(long id);
}
