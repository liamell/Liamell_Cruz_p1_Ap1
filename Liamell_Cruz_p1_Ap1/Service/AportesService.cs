using Liamell_Cruz_p1_Ap1.DAL;
using Liamell_Cruz_p1_Ap1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Liamell_Cruz_p1_Ap1.Service;

public class AportesService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Guardar(Aportes aportes)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        if (!await Existe(aportes.AporteId))
            return await Insertar(aportes);
        else
            return await Modificar(aportes);
    }

    private async Task<bool> Existe(int aporteId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Aportes
            .AnyAsync(a => a.AporteId == aporteId);

    }

    private async Task<bool> Insertar(Aportes aportes)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Aportes.Add(aportes);
        return await contexto.SaveChangesAsync()> 0;

    }

    private async Task<bool> Modificar(Aportes aportes)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Update(aportes);
        var modificado = await contexto.SaveChangesAsync() > 0;
        contexto.Entry(aportes).State = EntityState.Modified;
        return modificado;

    }


    public async Task<bool> Eliminar(int aporteId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Aportes
            .Where(a => a.AporteId == aporteId)
            .ExecuteDeleteAsync() > 0;

    }


    public async Task<Aportes> Buscar(int aporteId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Aportes
        .FirstOrDefaultAsync(a => a.AporteId == aporteId);
    }

    public async Task<List<Aportes>> Listar(Expression<Func<Aportes, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Aportes
            .Where(criterio)
            .ToListAsync();

    }


}
