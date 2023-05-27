namespace ConsoleApp1
{
    public class StudentServiceManager : IStudentService
    {
        public string GetUpperCaseText(string text)
        {
            return text.ToUpper();
        }
    }
}
