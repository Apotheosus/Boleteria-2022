using BoleteriaOnline.Web.Utils;
using BoleteriaOnline.Web.ViewModels.Requests;
using BoleteriaOnline.Web.ViewModels.Responses;

namespace BoleteriaOnline.Web.Services.Interface;
public interface INodoService
{
    Task<WebResult<ICollection<NodoResponse>>> GetNodosAsync();
    Task<WebResult<NodoResponse>> GetNodoAsync(long id);
    Task<WebResult<NodoResponse>> CreateNodoAsync(NodoRequest nodoDto);
    Task<WebResult<NodoResponse>> UpdateNodoAsync(NodoRequest nodoDto);
    Task<WebResult<NodoResponse>> DeleteNodoAsync(long id);
}
