using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SystemWeb.Model.Models;
using SystemWeb.Service;
using SystemWeb.Web.Infrastructure.Core;

namespace SystemWeb.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) :
            base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public IEnumerable<PostCategory> Getall()
        {
            return _postCategoryService.GetAll();
        }

        [Route("getall1")]
        public String Getall1()
        {
            return "The anh dep trai";
        }
    }
}