using Microsoft.AspNetCore.Mvc;
using RaveEnterprise.Data;
using RaveEnterprise.Models;

namespace RaveEnterprise.Controllers
{
    public class RaveController :ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public RaveController(ApplicationDbContext db)
        {
            _db = db; 
        }

    }
}
