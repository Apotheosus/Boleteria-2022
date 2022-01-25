using BoleteriaOnline.Web.Utils;
using BoleteriaOnline.Web.ViewModels.Requests;
using BoleteriaOnline.Web.ViewModels.Responses;

namespace BoleteriaOnline.Web.Services.Interface;
public interface IViajeService
{
    Task<WebResult<ICollection<ViajeResponse>>> GetViajesAsync();
    Task<WebResult<ViajeResponse>> GetViajeAsync(long id);
    Task<WebResult<ViajeResponse>> CreateViajeAsync(ViajeRequest viajeDto);
    Task<WebResult<ViajeResponse>> UpdateViajeAsync(ViajeRequest viajeDto);
    Task<WebResult<ViajeResponse>> DeleteViajeAsync(long id);
}
