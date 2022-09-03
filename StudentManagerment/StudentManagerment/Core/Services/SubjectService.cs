using StudentManagerment.Core.Interfaces.IData;
using StudentManagerment.Core.Interfaces.IServices;
using StudentManagerment.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerment.Core.Services
{
    public class SubjectService : ISubjectService
    {
        ISubjectData _data;
        public SubjectService(ISubjectData data)
        {
            this._data = data;
        }

        public List<Subject> All => _data.GetSubjects();

        public void showInfo(Subject subject)
        {
            Console.WriteLine("\t{0,-15}{1,-50}{2,-10}", subject.MaMonHoc, subject.TenMonHoc, subject.SoTiet.ToString());
        }
    }
}
