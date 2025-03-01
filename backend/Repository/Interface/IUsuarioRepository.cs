﻿using BoleteriaOnline.Web.Data.Models;

namespace BoleteriaOnline.Web.Repository.Interface;
public interface IUsuarioRepository
{
    Task<ICollection<Usuario>> GetUsuariosAsync();
    Task<Usuario> GetUsuarioAsync(int id);
    Task<Usuario> GetUsuarioByEmailAsync(string email);
    Task<Usuario> GetUsuarioByUserNameAsync(string userName);
    Task<bool> ExistsUsuarioAsync(int id);
    Task<bool> ExistsUsuarioByEmailAsync(string email);
    Task<bool> ExistsUsuarioByUserNameAsync(string userName);
    Task<bool> CreateUsuarioAsync(Usuario usuario);
    Task<bool> LockUsuarioAsync(int id);
    Task<bool> Save();
}
