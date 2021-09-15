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
    public class UserTypeController : ApiController
    {
        [Route("api/UserType/GetAll")]
        [HttpGet]
        public List<UserTypeModel> GetAllUserTypes()
        {
            return UserTypeService.GeUserTypes();
        }
        [Route("api/UserType/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return UserTypeService.GetUserTypesNames();
        }
    }
}
