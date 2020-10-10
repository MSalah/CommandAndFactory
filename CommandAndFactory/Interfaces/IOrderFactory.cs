﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAndFactory.Interfaces
{
    public interface IOrderFactory
    {
        string Name { get; }
        string Description { get; }
        IOrderCommand MakeInstance(string[] arguments);
    }
}