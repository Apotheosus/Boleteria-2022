using Microsoft.EntityFrameworkCore;
using BoleteriaOnline.Web.Data;
using BoleteriaOnline.Web.Data.Models;
using BoleteriaOnline.Core.Repositories;
using BoleteriaOnline.Core.Data.Enums;

namespace BoleteriaOnline.Web.Repository;

public class ClienteRepository : IClienteRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateClienteAsync(Cliente cliente)
    {
        cliente.CreatedAt = DateTime.Now;
        cliente.Id = 0;
        await _context.Clientes.AddAsync(cliente);
        return await Save();
    }

    public async Task<bool> DeleteClienteAsync(long id)
    {
        Cliente cliente = await GetClienteAsync(id);
        return await DeleteClienteAsync(cliente);
    }

    public async Task<bool> DeleteClienteAsync(Cliente cliente)
    {
        if (cliente == null)
            return false;

        if (cliente.Estado == Estado.BAJA)
            return false;

        cliente.Estado = Estado.BAJA;
        return await Save();
    }

    public async Task<bool> ExistsClienteAsync(long id) => await _context.Clientes.AnyAsync(e => e.Estado == Estado.NORMAL && e.Id == id);

    public async Task<Cliente> GetClienteAsync(long id) => await _context.Clientes.FirstOrDefaultAsync(m => m.Estado == Estado.NORMAL && m.Id == id);

    public async Task<ICollection<Cliente>> GetClientesAsync() => await _context.Clientes.Where(m => m.Estado == Estado.NORMAL).ToListAsync();

    public async Task<bool> Save() => await _context.SaveChangesAsync() >= 0;

    public async Task<bool> UpdateClienteAsync(Cliente cliente)
    {
        if (cliente == null || cliente.Estado == Estado.BAJA)
            return false;

        _context.Clientes.Update(cliente);
        cliente.UpdatedAt = DateTime.Now;
        return await Save();
    }
}
