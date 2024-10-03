using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using static EmployeeForm.Models.UserModel;

namespace EmployeeForm.Controllers
{
    public class BillsController : Controller
    {
        private IConfiguration _configuration;
        public BillsController(IConfiguration configuration)
        {
            _configuration = configuration;
          
        }
        public IActionResult Index()
        {
            string connectionstring = _configuration.GetConnectionString("ConnectionString");
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "PR_Bills_SelectAll";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            return View(dataTable);
        }
        public IActionResult AddBill() {
            string connectionString = this._configuration.GetConnectionString("ConnectionString");
            List<UserDropDownModel> userList = Database.GetUserList(connectionString);
            ViewBag.UserList = userList;

            List<OrderDropdownModel> orderList = Database.GetOrderList(connectionString);
            ViewBag.OrderList = orderList;
            return View();
        }

        [HttpPost]
        public IActionResult AddBill(BillsModel bill)
        {
           
            Database.bills.Add(bill);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteBill(int userId)
        {
            try
            {
                string ConnectionString = this._configuration.GetConnectionString("ConnectionString");
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PR_Bills_DeleteByPK";
                cmd.Parameters.AddWithValue("userId", userId);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) {
                TempData["Error"] = ex.Message;
            }

           
            return RedirectToAction("Index");
        }
    }
}
