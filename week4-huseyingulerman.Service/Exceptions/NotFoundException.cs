﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_huseyingulerman.Service.Exceptions
{
    public class NotFoundException:Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
