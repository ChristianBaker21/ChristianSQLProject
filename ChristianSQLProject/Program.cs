using Microsoft.Data.SqlClient;
using System;
using UtilityLibrayProject;

namespace ChristianSQLProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ss = new SQLServer();
            var ok = ss.Connect("localhost", "sqlexpress", "EdDb");

            var students = ss.ExcecuteQuery("SELECT * From Student;");

            ss.Disconnect();
        }
      
        }
       
        
        }
    

