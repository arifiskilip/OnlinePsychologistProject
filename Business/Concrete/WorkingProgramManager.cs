using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class WorkingProgramManager : IWorkingProgramService
    {
        private readonly IWorkingProgramDal _workingProgramDal;

        public WorkingProgramManager(IWorkingProgramDal workingProgramDal)
        {
            _workingProgramDal = workingProgramDal;
        }

        public void Add(WorkingProgram workingProgram)
        {
            _workingProgramDal.Add(workingProgram);
        }

        public void Delete(WorkingProgram workingProgram)
        {
            _workingProgramDal.Delete(workingProgram);
        }

        public List<WorkingProgram> GetAll()
        {
            return _workingProgramDal.GetAll();
        }

        public WorkingProgram GetById(int id)
        {
            return _workingProgramDal.Get(x=> x.Id == id);
        }

        public void Update(WorkingProgram workingProgram)
        {
            _workingProgramDal.Update(workingProgram);
        }
    }
}
