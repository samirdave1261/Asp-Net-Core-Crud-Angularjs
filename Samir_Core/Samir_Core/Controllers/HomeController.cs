using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Samir_Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace Samir_Core.Controllers
{
    public class HomeController : Controller
    {
        DataAccess DA = new DataAccess();
        private IConfiguration Configuration;
        private readonly ILogger<HomeController> _logger;
        string cons = string.Empty;
        public static int Rid = 0;
        public HomeController(ILogger<HomeController> logger,IConfiguration _configuration)
        {
            _logger = logger;
            Configuration = _configuration;
            cons = Configuration.GetConnectionString("myDb1");
        }
        public IActionResult Index()//<==Bind page
        {
            return View();
        }

        public IActionResult Privacy() //<==Insert||Update Page
        {
            return View();
        }
        [HttpPost]
        public JsonResult Insert_Data(IFormCollection Data) //<==Insert
        {
             string Query = $"insert into Core_insert (Fname,Lname,Email,mobile) Values ('{Data["fname"]}','{Data["lname"]}','{Data["email"]}','{Convert.ToInt64(Data["mobile"])}')";
             int i =  DA.ExcuteQuery(Query,cons);
             return Json( i > 0 ? "Success" : "Failed");
        }
        public JsonResult Update(IFormCollection Data)//<==Update
        {
            string Query = $"Update Core_insert set Fname='{Data["fname"]}',Lname='{Data["lname"]}',Email ='{Data["email"]}',mobile={Convert.ToInt64(Data["mobile"])} where RID = {Rid}";
            int i = DA.ExcuteQuery(Query,cons);
            return Json(i > 0 ? "Success" : "Failed");
        }
        [HttpGet]
        public JsonResult get_data(string id)
        {
            Rid = Convert.ToInt32(id); 
            return (Bind_Data(id));
        }
        [HttpGet]
        public JsonResult Bind_Data(string ID)//<==Bind
        {
            DataTable dt = new DataTable();
            string Query = ID == null ? "Select  * From Core_insert" : $"Select  * From Core_insert where RID = {Convert.ToInt16(ID)}";
            dt = DA.GetDatatable(Query,cons);
            return Json(JsonConvert.SerializeObject(dt));
        }
        [HttpPost]
        public JsonResult Delete(string delId)//<==Delete
        {
            string Query = $"Delete From Core_insert where RID = {Convert.ToInt32(delId)} ";
            int i = DA.ExcuteQuery(Query,cons);
            return Json("Success");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return RedirectToAction("Index","Home");
        }
    }
}
