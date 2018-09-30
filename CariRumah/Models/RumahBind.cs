using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CariRumah.Models
{
    public class RumahBind
    {
        public static async Task<List<Rumah>> ReadAllAsync(DbDataReader reader)
        {
            var posts = new List<Rumah>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var post = new Rumah()
                    {
                        id = int.Parse(reader["id"].ToString()),
                        tipe = reader["tipe"].ToString(),
                        alamat = reader["alamat"].ToString(),
                        latitude = decimal.Parse(reader["latitude"].ToString()),
                        longitude = decimal.Parse(reader["longitude"].ToString())
                    };
                    posts.Add(post);
                }
            }
            return posts;
        }

    }
}