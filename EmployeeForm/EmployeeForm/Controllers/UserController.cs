using EmployeeForm.Models;
using Microsoft.AspNetCore.Mvc;
using EmployeeForm.Models;
using System.Data.SqlClient;
using System.Data;
namespace EmployeeForm.Controllers
{
    public class UserController : Controller
    {
        private IConfiguration configuration;
       

        public UserController(IConfiguration _configuration)
        {
            configuration = _configuration;
           
        }

        public IActionResult Index()
        {
            string connectionString = this.configuration.GetConnectionString("ConnectionString");
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "PR_User_SelectAll";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            return View(dataTable);
        }

        public IActionResult ExportToExcel()
        {
            string connectionString = this.configuration.GetConnectionString("ConnectionString");
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "PR_User_SelectAll";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            var package = new OfficeOpenXml.ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Users");

            worksheet.Cells[1, 1].Value = "UserID";
            worksheet.Cells[1, 2].Value = "UserName";
            worksheet.Cells[1, 3].Value = "Email";
            worksheet.Cells[1, 4].Value = "Password";
            worksheet.Cells[1, 5].Value = "Mobile No";
            worksheet.Cells[1, 6].Value = "Address";
            worksheet.Cells[1, 7].Value = "Is Active";

            var row = 2;
            foreach(DataRow data in dataTable.Rows)
            {
                worksheet.Cells[row, 1].Value = data["UserId"];
                worksheet.Cells[row, 2].Value = data["UserName"];
                worksheet.Cells[row, 3].Value = data["Email"];
                worksheet.Cells[row, 4].Value = data["Password"];
                worksheet.Cells[row, 5].Value = data["MobileNo"];
                worksheet.Cells[row, 6].Value = data["Address"];
                worksheet.Cells[row, 7].Value = data["IsActive"];
                row++;

            }
            if (worksheet.Dimension != null)
            {
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
            }

            byte[] fileBytes = package.GetAsByteArray();
            string fileName = "Users.xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            return File(fileBytes, contentType, fileName);

          
        }

        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(UserModel user)

        {
           
            Database.users.Add(user);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteUser(int userId) {
            try
            {
                string ConnectionString = this.configuration.GetConnectionString("ConnectionString");
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PR_User_DeleteByPK";
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
