using Library.Models;
using Library.Models.Command;
using Library.Repositories.Implementation;
using Library.Repositories.Interface;
using Library.Services.Interface;

namespace Library.Services.Implementation
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void DeletePersonService(DeletePersonCommand command)
        {
            _personRepository.DeletePerson(command.PersonId);
        }

        public List<Person> GetAllPerson()
        {
           return _personRepository.GetAllPerson();
        }

        public Person GetPersonById(int id)
        {
           return _personRepository.GetpersonById(id);
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
            _personRepository.CreatePerson(person);
        }

        public Person UpdatePerson(UpdatePersonCommand command)
        {
            var updatePerson = _personRepository.GetpersonById(command.Id);
            if (updatePerson == null) return null;

            updatePerson.FirstName = command.FirstName;
            updatePerson.LastName = command.LastName;
            updatePerson.PhoneNumber = command.PhoneNumber;
            updatePerson.NationalCode = command.NationalCode;
            updatePerson.Address = command.Address;
            updatePerson.BirthDate = command.BirthDate;
            updatePerson.Mobile = command.Mobile;
            updatePerson.PhoneNumber = command.PhoneNumber;
            updatePerson.Height = command.Height;
            updatePerson.Weight = command.Weight;

            _personRepository.UpdatePerson(updatePerson);
            return updatePerson;

        }
    }
}
