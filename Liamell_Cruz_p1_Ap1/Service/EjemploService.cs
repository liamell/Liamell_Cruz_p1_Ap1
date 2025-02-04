using Liamell_Cruz_p1_Ap1.DAL;
using Liamell_Cruz_p1_Ap1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Liamell_Cruz_p1_Ap1.Service;

public class EjemploService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Guardar()
    {
        return true;
       
        
    }

    private async Task<bool> Existe()
    {
        return true;
        


    }

    private async Task<bool> Insertar()
    {
        return true;

    }

    private async Task<bool> Modificar()
    {
        return true;

    }

    public async Task<bool> Eliminar()
    {
        return true;


    }

    public async Task<bool> Buscar()
    {
        return true;

    }

    public async Task<List<Ejemplo>> Listar(Expression<Func<Ejemplo, bool>> criterio)
    {
        


    }
}
