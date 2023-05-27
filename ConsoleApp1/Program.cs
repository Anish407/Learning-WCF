using System;
using System.ServiceModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostStudentManager = new ServiceHost(typeof(StudentServiceManager));
            hostStudentManager.Open();

            Console.WriteLine("Service Started");
            Console.ReadKey();
            hostStudentManager.Close();
        }
    }
}
