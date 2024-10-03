using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using static EmployeeForm.Models.UserModel;

namespace EmployeeForm.Controllers
{
    public class OrderController : Controller
    {
        private IConfiguration _configuration;

        public OrderController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public int nextID = 1;
        public IActionResult Index()
        {
            string connectionstring = this._configuration.GetConnectionString("ConnectionString");
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "PR_Order_SelectAll";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            
            return View(dataTable);
        }

        public IActionResult AddOrder()
        {
            string connectionstring = this._configuration.GetConnectionString("ConnectionString");
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "PR_Customer_DropDown";
            SqlDataReader reader1 = sqlCommand.ExecuteReader();
            DataTable dataTable1 = new DataTable();
            dataTable1.Load(reader1);
            List<CustomerDropDownModel> customerlist = new List<CustomerDropDownModel>();
            foreach (DataRow data in dataTable1.Rows)
            {
                CustomerDropDownModel customerDropDownModel = new CustomerDropDownModel();
                customerDropDownModel.CustomerId = Convert.ToInt32(data["CustomerId"]);
                customerDropDownModel.CustomerName = data["CustomerName"].ToString();
                customerlist.Add(customerDropDownModel);
            }
            ViewBag.CustomerList = customerlist;
            sqlCommand.CommandText = "PR_User_DropDown";
            SqlDataReader reader2 = sqlCommand.ExecuteReader();
            DataTable dataTable2 = new DataTable();
            dataTable2.Load(reader2);
            List< UserDropDownModel> userlist = new List<UserDropDownModel>();
            foreach (DataRow data in dataTable2.Rows) { 
                UserDropDownModel userDropDownModel = new UserDropDownModel();
                userDropDownModel.UserId = Convert.ToInt32(data["UserId"]);
                userDropDownModel.UserName = data["UserName"].ToString();
                userlist.Add(userDropDownModel);
            }
            ViewBag.UserList = userlist;
            return View();
           
        }
        [HttpPost]
        public IActionResult Validate(OrderModel orderModel) {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View("AddOrder",orderModel);
        }

        

        [HttpPost]
        public IActionResult DeleteOrder(int UserID)
        {
            try
            {
                string connectionstring = this._configuration.GetConnectionString("ConnectionString");
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PR_Order_DeleteByPK";
                cmd.Parameters.AddWithValue("UserID", UserID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                TempData["Error"] = ex.Message;
            }
            
            return RedirectToAction("Index");
        }
    }
}
