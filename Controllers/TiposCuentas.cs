using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Presupuesto.Models;
using System.Data.Common;

namespace Presupuesto.Controllers
{
    
    public class TiposCuentas : Controller
    {
        private readonly string connectionString;
        public TiposCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnecction");
        }
        public IActionResult Crear()
        {


            using(var connection=new SqlConnection(connectionString))
            {
                var query=connection.Query("SELECT 1").FirstOrDefault();
            }

            return View();
        }
        [HttpPost]
        public IActionResult Crear(TipoCuentas tipoCuentas)
        { 
            if(!ModelState.IsValid)
            {
                return View(tipoCuentas);
            }
        
        return View();
        }

    }
}
