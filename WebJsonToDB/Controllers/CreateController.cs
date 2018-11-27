using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebJsonToDB.Controllers
{
    public class CreateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add([FromBody] JObject data)
        {
            GenerateDB gen = new GenerateDB();
            string json = data.ToString();
            Dictionary<string, string> fields = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            string nameTable = "";
            foreach (var i in fields)
            {
                nameTable = i.Value;
                break;
            }
            fields.Remove("nameTable");

            gen.Create(nameTable, fields);
            
            return View();
        }
    }
}