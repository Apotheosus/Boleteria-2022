using BoleteriaOnline.Core.Data.Enums;
using BoleteriaOnline.Web.Utils;
using BoleteriaOnline.Web.ViewModels.Requests;
using BoleteriaOnline.Web.ViewModels.Responses;

namespace BoleteriaOnline.Core.Services;
public interface IDistribucionService
{
    Task<WebResult<ICollection<DistribucionResponse>>> GetDistribucionesAsync();
    Task<WebResult<DistribucionResponse>> GetDistribucionAsync(long id);
    Task<WebResult<DistribucionResponse>> CreateDistribucionAsync(DistribucionRequest DistribucionDto);
    Task<WebResult<DistribucionResponse>> UpdateDistribucionAsync(DistribucionUpdateRequest DistribucionDto, long id);
    Task<WebResult<DistribucionResponse>> DeleteDistribucionAsync(long id);
    Task<WebResult<DistribucionResponse>> AppendFilasAsync(long id, Planta planta);
}
