using ATM.DAL.Model;

namespace ATM.DAL.Interface
{
    public interface IContactMessageRepository
    {
        Task<bool> CreateContactMessage(ContactMessage contactMessage);
    }
}
