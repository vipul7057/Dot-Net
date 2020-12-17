using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationEmployee.Models;

namespace WebApplicationEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        SqlConnection con;
    
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> lstEmp = new List<Employee>();
            con = new SqlConnection();
           
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=newDatabase;Integrated Security=true";
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            con.Open();
            SqlCommand cmd2 = cmd.Clone();
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                Employee emp = new Employee();
                int id = (int)dr["Empid"];
                string name = (string)dr["EmpName"];
                int Basic = (int)dr["EmpBasic"];
                int deptid = (int)dr["deptid"];
                emp.Empid = id;
                emp.EmpName = name;
                emp.EmpBasic = Basic;
                emp.deptid = deptid;

                lstEmp.Add(emp);

            }
            
            return View(lstEmp);



        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=newDatabase;Integrated Security=true";
            SqlCommand cmd = new SqlCommand("select * from Employee where empid ="+id, con);
            con.Open();
           // cmd.Parameters.Add(new SqlParameter { ParameterName = "@empid", SourceColumn = "empid", SourceVersion = DataRowVersion.Current });

            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Employee emp = new Employee();
                int id1 = (int)dr["Empid"];
                string name = (string)dr["EmpName"];
                int Basic = (int)dr["EmpBasic"];
                int deptid = (int)dr["deptid"];
                emp.Empid = id;
                emp.EmpName = name;
                emp.EmpBasic = Basic;
                emp.deptid = deptid;
                con.Close();
                return View(emp);
               
            }
            con.Close();
            return View();
           
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            Employee emp = new Employee();
            return View(emp);
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {

                con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=newDatabase;Integrated Security=True;Pooling=False";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Insertemployee";

                cmd.Parameters.AddWithValue("@empid", emp.Empid);
                cmd.Parameters.AddWithValue("@empName", emp.EmpName);
                cmd.Parameters.AddWithValue("@empBasic", emp.EmpBasic);
                cmd.Parameters.AddWithValue("@deptid", emp.deptid);

                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
           con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=newDatabase;Integrated Security=true";
            SqlCommand cmd = new SqlCommand("select * from employee where empid =" + id, con);
            con.Open();
            // cmd.Parameters.Add(new SqlParameter { ParameterName = "@empid", SourceColumn = "empid", SourceVersion = DataRowVersion.Current });
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Employee emp = new Employee();
                int id1 = (int)dr["Empid"];
                string name = (string)dr["EmpName"];
                int Basic = (int)dr["EmpBasic"];
                int deptid = (int)dr["deptid"];
                emp.Empid = id;
                emp.EmpName = name;
                emp.EmpBasic = Basic;
                emp.deptid = deptid;
                return View(emp);
               
            }
            return View();
        }

        
        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=newDatabase;Integrated Security=True;Pooling=False";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "UpdateEmployee";

                cmd.Parameters.AddWithValue("@empid", emp.Empid);
                cmd.Parameters.AddWithValue("@empName", emp.EmpName);
                cmd.Parameters.AddWithValue("@empBasic", emp.EmpBasic);
                cmd.Parameters.AddWithValue("@deptid", emp.deptid);

                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=newDatabase;Integrated Security=true";
            SqlCommand cmd = new SqlCommand("select * from employee where empid =" + id, con);
            con.Open();
            // cmd.Parameters.Add(new SqlParameter { ParameterName = "@empid", SourceColumn = "empid", SourceVersion = DataRowVersion.Current });
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Employee emp = new Employee();
                int id1 = (int)dr["Empid"];
                string name = (string)dr["EmpName"];
                int Basic = (int)dr["EmpBasic"];
                int deptid = (int)dr["deptid"];
                emp.Empid = id;
                emp.EmpName = name;
                emp.EmpBasic = Basic;
                emp.deptid = deptid;
                return View(emp);

            }
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,Employee emp)
        {
            try
            {

                con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=newDatabase;Integrated Security=True;Pooling=False";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DeleteEmployee";

                cmd.Parameters.AddWithValue("@empid", emp.Empid);

                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
