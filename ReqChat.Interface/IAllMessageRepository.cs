using ReqChatRepository.Models;

namespace ReqChat.Interface
{
    public interface IAllMessageRepository
    {
        IEnumerable<AllMessage> GetEmployees();
        AllMessage GetEmployeeByID(int employeeID);
        void InsertEmployee(AllMessage employee);
        void DeleteEmployee(int employeeID);
        void UpdateEmployee(AllMessage employee);


    }
}