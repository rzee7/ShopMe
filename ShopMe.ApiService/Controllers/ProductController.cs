using ShopMe.ApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopMe.ApiService.Controllers
{
    public class ProductController : ApiController
    {
        #region [Global Variables]

        APIResponse _response;

        #endregion

        // GET api/product
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/product/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        //[Route("NattachesAPI/Users")]
        public APIResponse GetProducts()
        {

            _response = new APIResponse();
            try
            {
                //_userobj = new UserBO();
                //_response.ResponseData = _userobj.GetUsers();
                //_response.Message = "Record Loaded Successfully !!";
                //_response.IsSucess = true;
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.Message = ex.Message.ToString();
            }
            return _response;
        }

        // POST api/product
        public void Post([FromBody]string value)
        {
        }

        // PUT api/product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/product/5
        public void Delete(int id)
        {
        }
    }
}
