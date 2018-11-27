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
    public class OpenController : Controller
    {
        public static string Id = "";
        public static string Table = "";
        public static string FColumn = "";
        public static string NameTable = "";

        public IActionResult Index(string nameTable)
        {
            dynamic colums = Tables.GetAllRows(nameTable);
            dynamic columNames = Tables.GetColumsName(nameTable);
            NameTable = nameTable;

            int count = columNames.Count;
            List<dynamic> id = new List<dynamic>();
            bool check = false;

            foreach (var i in colums)
            {
                foreach (var k in i)
                {
                    if (!check)
                    {
                        id.Add(k.Value);
                    }
                    check = true;
                }
                check = false;
            }

            ViewBag.Id = id;

            ViewBag.FColumn = columNames[0];
            ViewBag.Count = count;
            ViewBag.Colums = colums;
            ViewBag.ColumNames = columNames;
            ViewBag.Table = nameTable;

            return View();
        }

        public IActionResult Redirect()
        {
            return Redirect("/Open?nameTable=" + NameTable);
        }

        public IActionResult Delete(string id, string table, string fcolumn)
        {
            string sql = Tables.Delete(id, table, fcolumn);
            return Redirect("/Open?nameTable=" + table);
        }

        [HttpGet]
        public IActionResult Edit(string id, string table, string fcolumn)
        {
            dynamic row = Tables.GetRow(id, table, fcolumn);
            List<dynamic> values = new List<dynamic>();

            foreach (var i in row)
            {
                foreach (var k in i)
                {
                    values.Add(k.Value);
                }
                
            }
            Id = id;
            Table = table;
            FColumn = fcolumn;

            ViewBag.Id = id;
            ViewBag.RowInfo = row;
            ViewBag.Values = values;
            ViewBag.Fcolumn = fcolumn;
            return View();
        }

        [HttpPost]
        public IActionResult Edit(params string[] par)
        {
            string sql = Tables.Update(Id, Table, FColumn, par);
            return Redirect("/Open?nameTable=" + Table);
        }

        [HttpGet]
        public IActionResult Create(string table)
        {
            List<string> list = Tables.GetColumsName(table);
            Table = table;
            ViewBag.ColumsName = list;
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromBody] JObject data)
        {
            GenerateDB gen = new GenerateDB();
            string json = data.ToString();
            dynamic values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            gen.AddData(Table, values);
            ViewBag.Table = Table;

            return Redirect("/Open?nameTable=" + Table);
        }
    }
}