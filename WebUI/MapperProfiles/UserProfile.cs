using AutoMapper;
using Entities.Concrete;
using Entities.ViewModels;

namespace WebUI.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Customer, SignUpViewModel>();
            CreateMap<SignUpViewModel, Customer>();
        }
    }
}
