using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using static EmployeeForm.Models.UserModel;

namespace EmployeeForm.Controllers
{
   
    public class OrderDetailsController : Controller
    {
        private IConfiguration _configuration;
        public OrderDetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
           
        }

        public int nextId = 1;
        
        public IActionResult Index()
        {
            string connectionstring = _configuration.GetConnectionString("ConnectionString");
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "PR_OrderDetail_SelectAll";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            return View(dataTable);
        }

        public IActionResult AddDetails()
        {
            string connectionString = this._configuration.GetConnectionString("ConnectionString");
            SqlConnection sqlConnection = new SqlConnection( connectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "PR_Order_Dropdown";
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(reader1);

            List<OrderDropdownModel> orderList = new List<OrderDropdownModel>();
            foreach(DataRow data in table1.Rows)
            {
                OrderDropdownModel orderDropdownModel = new OrderDropdownModel();
                orderDropdownModel.OrderId = Convert.ToInt32(data["OrderId"]);
                orderList.Add(orderDropdownModel);
            }
            ViewBag.OrderList = orderList;
            

            List<UserDropDownModel> userList = Database.GetUserList(connectionString);
            ViewBag.UserList = userList;

            SqlConnection connection2 = new SqlConnection(connectionString);
            connection2.Open();
            SqlCommand cmd2 = connection2.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.StoredProcedure;
            cmd2.CommandText = "PR_Product_Dropdown";
            SqlDataReader reader2 = cmd2.ExecuteReader();
            DataTable table2 = new DataTable();
            table2.Load(reader2);

            List<ProductDropdownModel> productList = new List<ProductDropdownModel>();
            foreach(DataRow data in table2.Rows)
            {
                ProductDropdownModel productDropdownModel = new ProductDropdownModel();
                productDropdownModel.ProductId = Convert.ToInt32(data["ProductID"]);
                productDropdownModel.ProductName = data["ProductName"].ToString();
                productList.Add(productDropdownModel);
            }
            ViewBag.ProductList = productList;
            return View();
        }

        [HttpPost]
        public IActionResult AddDetails(OrderDetailModel detail)
        {
            detail.OrderDetailId = nextId++;
            Database.orderdetails.Add(detail);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteDetails(int userId) {
            try
            {
                string connectionstring = this._configuration.GetConnectionString("ConnectionString");
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PR_OrderDetail_DeleteByPK";
                cmd.Parameters.AddWithValue("userId", userId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                TempData["Error"] = ex.Message;
            }
           
            return RedirectToAction("Index");
        }
    }
}
