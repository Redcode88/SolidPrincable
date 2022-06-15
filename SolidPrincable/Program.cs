using SolidPrincable.LSP;
using SolidPrincable.OCP;
using SolidPrincable.OCP_2;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SolidPrincable
{
    class Program
    {
        static void Main(string[] args)
        {
            /// console main thred
            /// OCP Code

            #region OCP-Code
            //Manager1 emp = new Manager1
            //{
            //    EmpId = 2,
            //    empName = "Mohamed mohsen",
            //    Salary = 3000,
            //    OvertimeHours = 10
            //};
            //Regular1 emp2 = new Regular1
            //{
            //    EmpId = 2,
            //    empName = "Ahmed Goda",
            //    Salary = 3000,
            //    OvertimeHours = 10
            //};
            //var bonus = emp.CalclauteBounse();
            //var bounsReg = emp2.CalclauteBounse();

            //Console.WriteLine($"EmployeeDate :EmpID {emp.EmpId} EmployeeName : {emp.empName} \n BaseSalary {emp.Salary} \n Hours {emp.OvertimeHours} \n Bonus :{bonus}");
            //Console.WriteLine($"EmployeeDate :EmpID {emp2.EmpId} EmployeeName : {emp2.empName} \n BaseSalary {emp2.Salary} \n Hours {emp2.OvertimeHours} \n Bonus :{bounsReg}");
            //Console.ReadLine(); 
            #endregion

            PostDatabase db = new PostDatabase();
            List<string> userPosts = new List<string>();
            userPosts.Add("original Post");
            userPosts.Add("#tag Post");
            userPosts.Add("@mention post");

            Post postobj;
            foreach (var post in userPosts)
            {
                if (post.StartsWith("#"))
                {
                    postobj = new TagPost();
                }
                else if (post.StartsWith("@"))
                {
                    postobj = new MentionPost();
                }
                else
                {
                    postobj = new Post();
                }

                string result = postobj.CreatePost(db, post);
                Console.WriteLine(result);
            }

            Console.ReadKey();











        }
    }
}
