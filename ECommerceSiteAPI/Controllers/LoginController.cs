using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using System.Web.Http.Cors;
using System.Data;

namespace EcommerceAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        iLogin _iLoginRepository = new LoginRepository();

        [HttpPost]
        public HttpResponseMessage InsertRegistration(UserData userData)
        {
            int status = _iLoginRepository.InsertRegistration(userData);
            return Request.CreateResponse(HttpStatusCode.OK, status);
        }

        [HttpGet]
        public HttpResponseMessage UserLogin([FromUri]UserData loginData)
        {
            DataTable UserLogin = _iLoginRepository.UserLogin(loginData);
            return Request.CreateResponse(HttpStatusCode.OK, UserLogin);
        }

    }
}
