using System.ServiceModel;

namespace Client.WindowApp
{
    [ServiceContract(Namespace = "StudentService")]
    public interface IStudentService
    {
        [OperationContract]
        string GetUpperCaseText(string text);
       
    }
}
