﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjects
{
    public interface IDaoFactory
    {
        IPageDao PageDao { get; }
        IProductDao ProductDao { get; }
    }
}
