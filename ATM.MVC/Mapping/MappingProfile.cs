using ATM.DAL.Model;
using ATM.EN.DTOs.ContactMessage.Create;
using AutoMapper;

namespace ATM.MVC.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<ContactMessage, CreateContactMessageRequest>().ReverseMap();
        }
    }
}
