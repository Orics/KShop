using BussinessLayer.Models;
using BussinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ProductionsController : ApiController
    {
        private ProductionServices services;

        public ProductionsController()
        {
            services = new ProductionServices();
        }

        // GET: api/productions?isWithoutProducts=true
        public HttpResponseMessage Get(bool isWithoutProducts) {
            
            return Request.CreateResponse();
        }

        // GET: api/productions/id
        public HttpResponseMessage Get(int id) {
            return Request.CreateResponse();
        }

        // POST: api/productions/id
        public HttpResponseMessage Post() {
            return Request.CreateResponse();
        }

        // PUT: api/productions/id
        public HttpResponseMessage Put(int id)
        {
            return Request.CreateResponse();
        }

        // DELETE: api/productions/id
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse();
        }
    }
}
