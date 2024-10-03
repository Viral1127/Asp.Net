using CoffeeManagementSystem.Models;
using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using static EmployeeForm.Models.UserModel;

namespace EmployeeForm.Controllers
{
    public class CustomerController : Controller
    {
        private IConfiguration _configuration;
        public CustomerController(IConfiguration configuration)
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
            sqlCommand.CommandText = "PR_Customer_SelectAll";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            return View(dataTable);
        }

       public IActionResult AddCustomer()
        {
            string connectionString = this._configuration.GetConnectionString("ConnectionString");
            List<IDropDown> user = Database.GetDropDown(connectionString, "PR_User_DropDown", "UserID", "UserName");
            ViewBag.UserList = user;
            return View();
        }

        

        [HttpPost]

        public IActionResult DeleteCustomer(int userId) {
            try
            {
                string connectionString = this._configuration.GetConnectionString("ConnectionString");
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PR_Customer_DeleteByPK";
                cmd.Parameters.AddWithValue("userId", userId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                TempData["Error"] = ex.Message;
            }
           
            return RedirectToAction("Index");
        }
    }
}
