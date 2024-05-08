using System.Threading.Tasks;

namespace OnlineHelpDesk.Models
{
    public interface IEmailSender
    {
        Task<bool> EmailSendAsync(string email,string Subject, string message);
    }
}
