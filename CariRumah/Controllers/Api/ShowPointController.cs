using CariRumah.Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace CariRumah.Controllers.Api
{
    public class ShowPointController : ApiController
    {
        // GET: api/ShowPoint
        public async Task<HttpResponseMessage> Get()
        {
            AppDb.conn.Close();
            AppDb.conn.Open();

            string sql = "SELECT * FROM rumah";
            MySqlCommand cmd = new MySqlCommand(sql, AppDb.conn);
            DbDataReader rdr = cmd.ExecuteReader();

            List<Rumah> result = await RumahBind.ReadAllAsync(rdr);

            var resp = new HttpResponseMessage()
            {
                Content = new StringContent(
                    "{" +
                        "\"status\":200," +
                        "\"message\":\"success get all point\"," +
                        "\"results\": "+ JsonConvert.SerializeObject(result) + 
                    "}")

            };

            resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            AppDb.conn.Close();

            return resp;
        }

        // GET: api/ShowPoint/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ShowPoint
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ShowPoint/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ShowPoint/5
        public void Delete(int id)
        {
        }
    }
}
