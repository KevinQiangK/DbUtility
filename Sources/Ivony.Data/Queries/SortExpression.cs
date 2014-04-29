﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivony.Data.Queries
{
  public struct SortExpression
  {

    public FieldExpression SortField { get; private set; }

  }


  public enum SortDirection
  {
    /// <summary>正序</summary>
    Ascending,
    /// <summary>倒序</summary>
    Descending
  }
}