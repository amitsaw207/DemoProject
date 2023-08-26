using Microsoft.AspNetCore.Mvc;
using WebAPIProj.Extensions;
using WebAPIProj.Models;

namespace WebAPIProj.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
   public class UserController:ControllerBase
   {

    private readonly APIDBContext _dbContext;

    public UserController(APIDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetUsers()
    {
        var users = _dbContext.Users.ToList();
        return users;
    }

    [HttpGet("{id}")]
     public ActionResult<User> GetUsers(int id)
    {
        var user = _dbContext.Users.Find(id);
        return user;
    }

   }
    
}