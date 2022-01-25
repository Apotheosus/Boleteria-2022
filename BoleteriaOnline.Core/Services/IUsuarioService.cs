using BoleteriaOnline.Web.Utils;
using BoleteriaOnline.Web.ViewModels.Requests;
using BoleteriaOnline.Web.ViewModels.Responses;

namespace BoleteriaOnline.Web.Services.Interface;
public interface IUsuarioService
{
    Task<WebResult<ICollection<UsuarioResponse>>> GetUsuariosAsync();
    Task<WebResult<UsuarioResponse>> GetUsuarioAsync(int id);
    Task<WebResult<UsuarioResponse>> GetUsuarioByEmailAsync(string email);
    Task<WebResult<UsuarioResponse>> GetUsuarioByUserNameAsync(string userName);
    Task<WebResult<UsuarioResponse>> CreateUsuarioAsync(RegistroRequest request);
    Task<WebResult<UsuarioResponse>> LockUsuarioAsync(int id);
    Task<WebResult<LoginResponse>> LoginUsuarioAsync(LoginRequest request);
}
