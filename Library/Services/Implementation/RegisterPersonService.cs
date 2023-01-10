using Library.Models;
using Library.Models.Command;
using Library.Repositories.Interface;
using Library.Services.Interface;

namespace Library.Services.Implementation
{
    public class RegisterPersonService : IRegisterPersonService
    {
        private readonly IPersonRepository personRepository;

        public RegisterPersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public void RegisterPerson(RegisterPersonCommand command)
        {
            var person = new Person()
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                BirthDate = command.BirthDate,
                Address = command.Address,
                Height = command.Height,
                Weight = command.Weight,
                Mobile = command.Mobile,
                NationalCode = command.NationalCode,
                PhoneNumber = command.PhoneNumber,
            };
            personRepository.CreatePerson(person);
        }
    }
}
