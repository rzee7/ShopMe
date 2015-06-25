using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace ShopMe.ApiService.Controllers
{

    public class CategoryController : ApiController
    {
        #region  Global Variables

        //APIResponse _response;
        //UserBO _userobj;
        //Category _vendorobj;

        #endregion
        private shopmeEntities _db = new shopmeEntities();
        // GET api/category
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/category/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/category
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/category/5
        //public void Put(int id, [FromBody]string value)
        //{

        //}

        //// DELETE api/category/5
        //public void Delete(int id)
        //{
        //}

        //public IEnumerable<Category> Get()
        //{
        //    return _db.Categories.ToList();
        //}

        /// <summary>
        /// Function is used to fetch venfor information.
        /// </summary>
        /// <returns>Object of APIResponse</returns>   
        //[HttpPost]
        //[Route("NattachesAPI/SaveVendor")]
        //public APIResponse SaveVendor(Category Categoryobj)
        //{
        //    _response = new APIResponse();
        //    try
        //    {
        //        _vendorobj = new Category();
        //        _response.ResponseData = _vendorobj.(Categoryobj);
        //        _response.Message = "Record Saved Successfully !!";
        //        _response.IsSucess = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        _response.IsSucess = false;
        //        _response.Message = ex.Message.ToString();
        //    }

        //    return _response;
        //}
        // GET /api/<controller>
        public IEnumerable<Category> Get()
        {
            return _db.Categories.ToList();
        }

        // GET /api/<controller>/5
        public Category Get(int id)
        {
            return _db.Categories.Single(p => p.CategoryId == id);
        }

        // POST /api/<controller>
        public void Post(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
            }
        }

        // PUT /api/<controller>/5
        public void Put(int id, Category product)
        {
            var orgcategory = _db.Categories.Single(p => p.CategoryId == id);
            // Copy properties from product to orgProduct
            _db.SaveChanges();
        }

        // DELETE /api/<controller>/5
        public void Delete(int id)
        {
            var category = _db.Categories.Single(p => p.CategoryId == id);
            _db.Categories.Remove(category);
            _db.SaveChanges();
        }
    }
}
