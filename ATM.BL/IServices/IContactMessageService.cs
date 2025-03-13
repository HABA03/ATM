using ATM.EN.DTOs.ContactMessage.Create;

namespace ATM.BL.IServices
{
    public interface IContactMessageService
    {
        Task<CreateContactMessageResponse> CreateContactMessage(CreateContactMessageRequest request);
    }
}
