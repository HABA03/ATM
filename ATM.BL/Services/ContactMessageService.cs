using ATM.BL.IServices;
using ATM.DAL.Interface;
using ATM.DAL.Model;
using ATM.EN.DTOs.ContactMessage.Create;
using AutoMapper;
using System.Text.RegularExpressions;

namespace ATM.BL.Services
{
    public class ContactMessageService : IContactMessageService
    {
        private readonly IContactMessageRepository _contactMessageRepository;
        private readonly IMapper _mapper;
        public ContactMessageService(IContactMessageRepository contactMessageRepository, IMapper mapper)
        {
            _contactMessageRepository = contactMessageRepository;
            _mapper = mapper;   
        }

        public async Task<CreateContactMessageResponse> CreateContactMessage(CreateContactMessageRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            if (!IsValidEmail(request.Email))
                throw new ArgumentException("Invalid email format", nameof(request.Email));

            var response = await _contactMessageRepository.CreateContactMessage(_mapper.Map<ContactMessage>(request));
            return new CreateContactMessageResponse { Response = response };
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
