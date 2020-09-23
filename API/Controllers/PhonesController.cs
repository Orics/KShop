
using BussinessLayer.Models;
using BussinessLayer.Services;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    public class PhonesController : ApiController
    {
        private PhoneServices _services;

        public PhonesController() {
            _services = new PhoneServices();
        }

        // GET: api/Phones
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _services.GetAllPhones());
        }

        // GET: api/Phones/Id
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _services.GetAllPhones());
        }

        // PUT: api/Phones/Id
        public HttpResponseMessage Put(int id)
        {
             return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST: api/Phones
        public HttpResponseMessage Post()
        {
            var data = HttpContext.Current.Request.Form.Get("data");

            if (data == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            PhoneModelRequest phone = JsonConvert.DeserializeObject<PhoneModelRequest>(data);

            int id = _services.CreatePhone(phone);

            foreach (var name in HttpContext.Current.Request.Files.AllKeys) {
                if (!string.IsNullOrEmpty(name)) {
                    var img = HttpContext.Current.Request.Files.Get("img");
                    var extension = System.IO.Path.GetExtension(img.FileName);
                    img.SaveAs(
                        HttpContext.Current.Server.MapPath("~/App_Data/Images/") + id + "_" + name + extension
                    );
                }
            }

            return Request.CreateResponse(HttpStatusCode.OK);

        }


        // DELETE: api/Phones/Id
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }


        // POST: api/Phones/Images
        [HttpPost]
        [Route("api/phones/image")]
        public HttpResponseMessage Image()
        {
            var id = HttpContext.Current.Request.Form.Get("id");
            var name = HttpContext.Current.Request.Form.Get("name");
            var img = HttpContext.Current.Request.Files.Get("img");
            var extension = System.IO.Path.GetExtension(img.FileName);

            img.SaveAs(
                HttpContext.Current.Server.MapPath("~/App_Data/Images/") +
                id +
                "_" +
                name +
                extension
            );

            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
