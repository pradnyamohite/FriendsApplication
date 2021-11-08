using FriendApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using FriendApplication.Data;

namespace FriendApplication.Controllers
{
    public class HomeController : Controller
    {
      
        db dbop = new db();
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private CoreDatabaseContext _context;

        //public HomeController(CoreDatabaseContext context)
        //{
        //    _context = context;
        //}

        public IConfiguration Configuration { get; set; }
        public HomeController(IConfiguration configuration,CoreDatabaseContext context)
        {
            Configuration = configuration;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(TbLogin lg)
        {
            try
            {
                if (lg != null)
                {
                    string connectionString = Configuration["ConnectionStrings:defaultConnection"];
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string sql = $"Insert into TbLogin (MobileNo,Password,Name)values ('{lg.MobileNo}','{lg.Password}','{lg.Name}')";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.CommandType = CommandType.Text;
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        ViewBag.Notification = "In login function";
                        return RedirectToAction("loginUser");
                    }

                }
                else
                    return View();
            }
            catch (Exception ex) {
                var a = ex.Message;
                    return null;
            }
        }

        public ActionResult loginUser()
        {
            return View();
        }




        [HttpPost]
        public ActionResult loginUser(TbLogin ulg)
        {
            ViewBag.Notification = "In login function";
            try
            {
                if (ulg != null)
                {
                    string connectionString = Configuration["ConnectionStrings:defaultConnection"];
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "select MobileNo,Password from TbLogin Where MobileNo='" + ulg.MobileNo + "'AND Password ='" + ulg.Password + "'";
                        //if (ulg.MobileNo == sql)
                        //{
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        return RedirectToAction("frdListView");
                        //} else
                        //{
                        //    return RedirectToAction("Index");
                        //}
                    }
                }
                else
                    return View();
            }
            catch (Exception ex)
            {
                var b = ex.Message;
                return null;
            }

        }


        public ActionResult Create() {
            return View();
        }
        


        [HttpPost]
        public ActionResult Create(frd_create flg)
        {
            try
            {
                if (flg != null)
                {
                    string connectionString = Configuration["ConnectionStrings:defaultConnection"];
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string sql = $"Insert into frd_create (Fname,Lname,MobileNo,Email)values ('{flg.Fname}','{flg.Lname}','{flg.MobileNo}','{flg.Email}')";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.CommandType = CommandType.Text;
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        ViewBag.Notification = "In login function";
                        return RedirectToAction("frdListView");
                    }

                }
                else
                    return View();
            }
            catch (Exception ex)
            {
                var a = ex.Message;
                return null;
            }
        }

        //pradnya code
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //var a = frdListView();
            frd_create fd = new frd_create();
            try
            {
                if (id != null)
                {
                    
                    string connectionString = Configuration["ConnectionStrings:defaultConnection"];
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("GetEmpById", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        
                        while (dr.Read())
                        {
                            

                            fd.UserId = Convert.ToInt32(dr["UserId"]);
                            fd.Fname = Convert.ToString(dr["Fname"]);
                            fd.Lname = Convert.ToString(dr["Lname"]);
                            fd.MobileNo = Convert.ToString(dr["MobileNo"]);
                            fd.Email = Convert.ToString(dr["Email"]);
                        }

                    }
                }
                else
                    return View(fd);
            }
            catch (Exception ex)
            {
                var b = ex.Message;
                return null;
            }
            return View(fd);
        }

        [HttpPost]
        public ActionResult Edit(frd_create fredit)
        {
            try
            {
                if (fredit != null)
                {
                    string connectionString = Configuration["ConnectionStrings:defaultConnection"];
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string sql = $"Update frd_create set Fname= '{fredit.Fname}',Lname='{fredit.Lname}',MobileNo='{fredit.MobileNo}',Email='{fredit.Email}' where UserId='{fredit.UserId}' ";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.CommandType = CommandType.Text;
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        ViewBag.Notification = "In login function";
                        return RedirectToAction("frdListView");
                    }

                }
                else
                    return View();
            }
            catch (Exception ex)
            {
                var a = ex.Message;
                return null;
            }
        }
        

        [HttpPost]
        public ActionResult cnfDelete(int id)
        {
            //ListView listview = new ListView();
            //listview.Delete(id);
            try
            {
                if (id != 0)
                {
                    string connectionString = Configuration["ConnectionStrings:defaultConnection"];
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string sql = $"delete from frd_create where UserId =" + id;
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.CommandType = CommandType.Text;
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        ViewBag.Notification = "In login function";
                        return RedirectToAction("frdListView");
                    }

                }
                else
                    return View();
            }
            catch (Exception ex)
            {
                var a = ex.Message;
                return null;
            }

          //  return RedirectToAction("frdListView");
        }

        public ActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Details(frd_create frd)
        {
            return View();
        }

        //public ActionResult frdListView()
        //{
        //    return View();
        //}

        public ActionResult frdListView()
        {
            try
            {
                //var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                //// Skiping number of Rows count  
                //var start = Convert.ToInt32(Request.Form["start"].FirstOrDefault());
                //// Paging Length 10,20  
                //var length = Request.Form["length"].FirstOrDefault();
                //// Sort Column Name  
                //var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                ////Sort Column Direction(asc, desc)
                //var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                //// Search Value from (Search box)  
                //var searchValue = Request.Form["search[value]"].FirstOrDefault();

                ////Paging Size (10,20,50,100)  
                //int pageSize = length != null ? Convert.ToInt32(length) : 0;
                //int skip = start != null ? Convert.ToInt32(start) : 0;
                //int recordsTotal = 0;

                // Getting all Customer data  
                var customerData = (from tempData in _context.frd_create
                                    select tempData);

                //Sorting  
                //if (!(string.isnullorempty(sortcolumn) && string.isnullorempty(sortcolumndirection)))
                //{
                //    customerdata = customerdata.orderby(sortcolumn + " " + sortcolumndirection);
                //}
                //Search  
                //if (!string.IsNullOrEmpty(searchValue))
                //{
                //    customerData = customerData.Where(m => m.Fname == searchValue);
                //}

                //total number of rows count   
                //recordsTotal = customerData.Count();
                //Paging   
                var data = customerData.ToList();
                //Returning Json Data  
                //return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
                return View(data);

            }
            catch (Exception ex)
            {
                var a = ex.Message;
                return null;
            }

        }
    


        //pradnys code end


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
