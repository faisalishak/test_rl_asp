using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace CariRumah.Controllers.Api
{
    public class JarakController : ApiController
    {
        // GET: api/Jarak
        public HttpResponseMessage Get(double lat1, double lon1, double lat2, double lon2)
        {
            double rlat1 = Math.PI * lat1 / 180;
            double rlat2 = Math.PI * lat2 / 180;
            double theta = lon1 - lon2;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            double result;
            result = dist * 1.609344;

            var resp = new HttpResponseMessage()
            {
                Content = new StringContent(
                    "{" +
                        "\"status\":200," +
                        "\"message\":\"success get distance\"," +
                        "\"result\": " + JsonConvert.SerializeObject(result) +
                    "}")

            };
            resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return resp;
        }

        // GET: api/Jarak/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Jarak
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Jarak/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Jarak/5
        public void Delete(int id)
        {
        }
    }
}
