using Library.Models;
using Library.Models.Command;
using Library.Repositories.Interface;
using Library.Services.Interface;

namespace Library.Services.Implementation
{
    public class CommandTeacherService : ICommandTeacherService
    {
        private readonly ITeacherRepository teacherRepository;

        public CommandTeacherService(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        public int RegisterTeacher(RegisterTeacherCommand command)
        {
            var teacher = new Teacher()
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                BirthDate = command.BirthDate,
                Address = command.Address,
                NationalCode = command.NationalCode,
                Height = command.Height,
                Weight = command.Weight,
                Mobile = command.Mobile,
                PhoneNumber = command.PhoneNumber,
                NumberOfChilds = command.NumberOfChilds,
                Sports = command.Sports,
                Introduction = command.Introduction,
                SubjectId = command.SubjectId,
            };
            return teacherRepository.CreateTeacher(teacher);
        }
        public void EditTeacher(EditTeacherCommand command)
        {
            var teacher = teacherRepository.GetTeacherById(command.Id);

            {
                teacher.FirstName = command.FirstName;
                teacher.LastName = command.LastName;
                teacher.BirthDate = command.BirthDate;
                teacher.Address = command.Address;
                teacher.Height = command.Height;
                teacher.Weight = command.Weight;
                teacher.Mobile = command.Mobile;
                teacher.PhoneNumber = command.PhoneNumber;
                teacher.NumberOfChilds = command.NumberOfChilds;
                teacher.Sports = command.Sports;
                teacher.Introduction = command.Introduction;
                teacher.SubjectId = command.SubjectId;
                teacherRepository.Update(teacher);
            }
        }
        public void DeleteTeacher(int id)
        {
            teacherRepository.Remove(id);
        }
        public void DecreaseBalanceTeacher(DecreaseBalanceTeacher command)
        {
            if (command.Balance <= 0)
            {
                throw new Exception(" Balance chould not be zero or minus! ");
            }
            var teacher = teacherRepository.GetTeacherById(command.Id);
            teacher.Balance += command.Balance;
            teacherRepository.Update(teacher);

        }
        public void TeachersTimeCommand(TeachersTimeCommand command)
        {

        }

        public void DatailsTeacher(DatailsTeacherCommand command)
        {
            var teacher = teacherRepository.GetTeacherById(command.Id);
            teacherRepository.Update(teacher);
        }
    }
}
