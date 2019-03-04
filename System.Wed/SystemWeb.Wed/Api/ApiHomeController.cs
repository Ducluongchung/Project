using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Web.Http;
using SystemWeb.Data.Infastructure;
using SystemWeb.Service;

namespace SystemWeb.Wed.Api
{
   [RoutePrefix("api/home")]
    public class ApiHomeController : ApiController
    {
        private readonly IPostService _postService;

        private readonly IUnitOfWork _unitOfWork;
       
        public ApiHomeController( IPostService postService,IUnitOfWork unitOfWork)
        {
            _postService = postService;
            _unitOfWork = unitOfWork;
        }
        [Route("getall")]
        public IHttpActionResult GetProduct(int id)
        {
            var model = _postService.GetAll();
            return Ok(model);
        }
    }
}
