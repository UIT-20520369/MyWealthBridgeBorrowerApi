﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SeedWord
{
    public interface IRepository<T> where T : IAggregateRoot
    {
    }
}
