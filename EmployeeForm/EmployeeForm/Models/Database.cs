using static EmployeeForm.Models.UserModel;
using System.Data.SqlClient;
using System.Data;
using CoffeeManagementSystem.Models;

namespace EmployeeForm.Models
{
    public class Database
    {
      
        public static List<UserModel> users = new List<UserModel>   
        { 
        };
        public static List<ProductModel> products = new List<ProductModel>
        {

        };
        public static List<BillsModel> bills = new List<BillsModel>
        {
            
        };
        public static List<CustomerModel> customers = new List<CustomerModel>
        {
           
        };
        public static List<OrderModel> orders = new List<OrderModel> {
           
        };
        public static List<OrderDetailModel> orderdetails = new List<OrderDetailModel> {
            
        };
        public static List<Department> departments = new List<Department> {
           new Department { DepartmentId=1 , DepartmentName="vc"},
           new Department { DepartmentId=2 , DepartmentName="jen"}
        };

        public static List<UserDropDownModel> GetUserList(string connectionString)
        {
            List<UserDropDownModel> userList = new List<UserDropDownModel>();


            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandText = "PR_User_DropDown";

                    using (SqlDataReader reader1 = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable1 = new DataTable();
                        dataTable1.Load(reader1);
                        
                        foreach (DataRow data in dataTable1.Rows)
                        {
                            UserDropDownModel userDropDownModel = new UserDropDownModel();
                            userDropDownModel.UserId = Convert.ToInt32(data["UserID"]);
                            userDropDownModel.UserName = data["UserName"].ToString();
                            userList.Add(userDropDownModel);
                        }
                    }
                        
                }
                    

            }
           
            return userList;
        }

        public static List<IDropDown> GetDropDown(string connectionString, string procedure, string idField , string valueField)
        {
            List<IDropDown> dropDown = new List<IDropDown>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandText = procedure;

                    using (SqlDataReader reader1 = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable1 = new DataTable();
                        dataTable1.Load(reader1);

                        foreach (DataRow data in dataTable1.Rows)
                        {
                            IDropDown dropDownData = new IDropDown();
                            dropDownData.id = Convert.ToInt32(data[idField]);
                            dropDownData.value = data[valueField].ToString();
                            dropDown.Add(dropDownData);
                        }
                    }

                }


            }
            return dropDown;

        }

        public static List<OrderDropdownModel> GetOrderList(string connectionString)
        {
            List<OrderDropdownModel> orderList = new List<OrderDropdownModel>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandText = "PR_Order_Dropdown";
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        foreach (DataRow data in dataTable.Rows)
                        {
                            OrderDropdownModel orderDropdownModel = new OrderDropdownModel();
                            orderDropdownModel.OrderId = Convert.ToInt32(data["OrderId"]);
                            orderList.Add(orderDropdownModel);
                        }
                    }
                }

            }
            return orderList;
        }
    }

}
