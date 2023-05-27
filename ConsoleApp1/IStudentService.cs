using System.ServiceModel;

namespace ConsoleApp1
{
    [ServiceContract(Namespace = "StudentService")]
    public interface IStudentService
    {
        [OperationContract]
        string GetUpperCaseText(string text);
       
    }
}
