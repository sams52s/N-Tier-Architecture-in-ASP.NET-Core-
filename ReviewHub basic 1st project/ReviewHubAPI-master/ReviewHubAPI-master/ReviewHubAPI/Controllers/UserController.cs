using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ReviewHubAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        [Route("api/User/GetAll")]
        [HttpGet]
        public List<UserModel> GetAllUsers()
        {
            return UserService.GetAllUsers();
        }

      
        [Route("api/User/{id}")]
        public UserModel GetStudent(int id)
        {
            return UserService.GetUser(id);
        }
        [Route("api/User/Add")]
        public void AddStudent(UserModel model)
        {
            UserService.AddUser(model);
        }
        [Route("api/User/Names")]
        public List<string> GetStudentNames()
        {
            return UserService.GetUserNames();
        }
    }
}
