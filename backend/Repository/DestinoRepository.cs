using Microsoft.EntityFrameworkCore;
using BoleteriaOnline.Web.Data;
using BoleteriaOnline.Web.Repository.Interface;
using BoleteriaOnline.Web.Data.Models;
using BoleteriaOnline.Web.Data.Models.Enums;

namespace BoleteriaOnline.Web.Repository;

public class DestinoRepository : IDestinoRepository
{
    private readonly ApplicationDbContext _context;

    public DestinoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateDestinoAsync(Destino destino)
    {
        destino.CreatedAt = DateTime.Now;
        destino.Id = 0;
        await _context.Destinos.AddAsync(destino);
        return await Save();
    }

    public async Task<bool> DeleteDestinoAsync(long id)
    {
        Destino destino = await GetDestinoAsync(id);
        return await DeleteDestinoAsync(destino);
    }

    public async Task<bool> DeleteDestinoAsync(Destino destino)
    {
        if (destino == null)
            return false;

        if (destino.Estado == Estado.BAJA)
            return false;

        destino.Estado = Estado.BAJA;
        return await Save();
    }

    public async Task<bool> ExistsDestinoAsync(long id) => await GetDestinoAsync(id) != null;

    public async Task<Destino> GetDestinoAsync(long id) => await _context.Destinos.FirstOrDefaultAsync(m => m.Estado == Estado.NORMAL && m.Id == id);

    public async Task<ICollection<Destino>> GetDestinosAsync() => await _context.Destinos.Where(m => m.Estado == Estado.NORMAL).ToListAsync();

    public async Task<bool> Save() => await _context.SaveChangesAsync() >= 0;

    public async Task<bool> UpdateDestinoAsync(Destino destino)
    {
        if (destino == null || destino.Estado == Estado.BAJA)
            return false;

        _context.Destinos.Update(destino);
        destino.UpdatedAt = DateTime.Now;
        return await Save();
    }
}
