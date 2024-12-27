using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avocadoria_project_2
{
    internal class LoggedInLabel
    {
    }

    public static class LoggedInEmployee
    {
        public static string EmployeeName { get; private set; }
        public static string Role { get; private set; }

        public static void SetLoggedInEmployee(string employeeName, string role)
        {
            EmployeeName = employeeName;
            Role = role;
        }
    }
}
