using System.ServiceModel;

namespace Client.WindowApp
{
    public class StudentClient : ClientBase<IStudentService>, IStudentService
    {
        public StudentClient(string endpointName)
            : base(endpointName)
        {

        }

        public string GetUpperCaseText(string text)
        {
            return Channel.GetUpperCaseText(text);
        }
    }
}
