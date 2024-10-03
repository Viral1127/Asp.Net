using CoffeeManagementSystem.Models;
using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using static EmployeeForm.Models.UserModel;

namespace EmployeeForm.Controllers
{
    public class ProductController : Controller
    {
        private IConfiguration configuration;

        public ProductController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public static int nextId = 1;


        public IActionResult Index()
        {
            string connectionString = this.configuration.GetConnectionString("ConnectionString");
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "PR_Product_SelectAll";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            return View(dataTable);
        }


        public IActionResult AddProduct(ProductModel productModel)
        {
            string connectionString = this.configuration.GetConnectionString("ConnectionString");

            List<IDropDown> dropDown = Database.GetDropDown(connectionString, "PR_User_DropDown", "UserID", "UserName");
            ViewBag.UserList = dropDown;

           

            return View(productModel);

        }




        [HttpPost]
        public IActionResult Validate(ProductModel productModel)
        {
            
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View("AddProduct", productModel);
        }

        [HttpPost]
        public IActionResult DeleteProduct(int UserId)
        {
            try
            {
                string connectionstring = configuration.GetConnectionString("ConnectionString");
                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PR_Product_DeleteByPK";
                cmd.Parameters.AddWithValue("UserId", UserId);
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


//Index->return List page
//AddEditForm -> return Form View ( if id passed to fetch product and pass it with view)
//Save -> Insert orr Update
//Delete
//