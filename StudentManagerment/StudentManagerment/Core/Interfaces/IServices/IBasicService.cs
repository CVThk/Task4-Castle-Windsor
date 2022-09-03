using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerment.Core.Interfaces.IServices
{
    public interface IBasicService<T>
    {
        List<T> All { get; }
    }
}
