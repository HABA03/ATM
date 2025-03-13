using ATM.DAL.Context;
using ATM.DAL.Interface;
using ATM.DAL.Model;

namespace ATM.DAL.Implementation
{
    public class ContactMessageRepository : IContactMessageRepository
    {
        private readonly ATMDbContext _context;
        public ContactMessageRepository(ATMDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateContactMessage(ContactMessage contactMessage)
        {
            bool result = false;
            if (contactMessage != null) 
            {
                contactMessage.CreatedDate = DateTime.Now;
                await _context.ContactMessage.AddAsync(contactMessage);
                result = await _context.SaveChangesAsync() > 0;
            }
            return result;
        }
    }
}
