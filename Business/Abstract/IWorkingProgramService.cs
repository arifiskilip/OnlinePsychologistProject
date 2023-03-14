using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IWorkingProgramService
    {
        List<WorkingProgram> GetAll();
        WorkingProgram GetById(int id);
        void Add(WorkingProgram workingProgram);
        void Delete(WorkingProgram workingProgram);
        void Update(WorkingProgram workingProgram);
    }
}
