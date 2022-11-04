﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using starkov.Qualifications.CompetenceModel;

namespace starkov.Qualifications.Shared
{
  partial class CompetenceModelFunctions
  {

    /// <summary>
    /// Сформировать имя.
    /// </summary>       
    public void GenerateName()
    {
      var name = string.Empty;
      
      if (_obj.JobTitle != null && _obj.Level != null)
        _obj.Name = string.Format("{0} - {1}", _obj.Level.Name, _obj.JobTitle);
      
    }

  }
}