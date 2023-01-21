using Library.Models;
using Library.Models.Command;
using Library.Repositories.Interface;
using Library.Services.Interface;

namespace Library.Services.Implementation
{
    public class CommandPersonService : ICommandPersonService
    {
        private readonly IPersonRepository personRepository;

        public CommandPersonService(IPersonRepository personRepository)
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


        public void EditPerson(EditPersonCommand command)
        {
            var person = personRepository.GetPersonById(command.Id);

            person.FirstName = command.FirstName;
            person.LastName = command.LastName;
            person.BirthDate = command.BirthDate;
            person.Weight = command.Weight;
            person.Height = command.Height;
            person.PhoneNumber = command.PhoneNumber;
            person.Mobile = command.Mobile;
            person.Address = command.Address;
            person.NationalCode = command.NationalCode;

            personRepository.Update(person);

        }

    }
}
