using ATM.BL.IServices;
using ATM.BL.Services;
using ATM.DAL.Implementation;
using ATM.DAL.Interface;

namespace ATM.MVC.DependencyInjection
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services) 
        {
            services.AddScoped<IContactMessageService, ContactMessageService>();

            services.AddTransient<IContactMessageRepository, ContactMessageRepository>();
        }
    }
}
