using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using starkov.Qualifications.CategoryLevel;

namespace starkov.Qualifications.Shared
{
  partial class CategoryLevelFunctions
  {
    /// <summary>
    /// Сформировать имя.
    /// </summary>       
    public void GenerateName()
    {
      if (_obj.Unit != null && _obj.Level != null)
        _obj.Name = string.Format("{0} {1}", _obj.Level, _obj.Unit);
      
    }
  }
}