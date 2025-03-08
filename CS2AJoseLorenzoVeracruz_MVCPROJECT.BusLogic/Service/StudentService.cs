using CS2AJoseLorenzoVeracruz_MVCPROJECT.BusLogic.Repository;
using CS2AJoseLorenzoVeracruz_MVCPROJECT.BusLogic.Model;
namespace CS2AJoseLorenzoVeracruz_MVCPROJECT.BusLogic.Service
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository = new StudentRepository();

        public IEnumerable<tblStudent> GetAll()
        {
            return _studentRepository.GetAll();
        }



    }
}
