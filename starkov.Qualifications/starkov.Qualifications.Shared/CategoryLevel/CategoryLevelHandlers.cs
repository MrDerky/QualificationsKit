using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using starkov.Qualifications.CategoryLevel;

namespace starkov.Qualifications
{
  partial class CategoryLevelSharedHandlers
  {

    public virtual void LevelChanged(Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e)
    {
      Functions.CategoryLevel.GenerateName(_obj);
    }

    public virtual void UnitChanged(Sungero.Domain.Shared.StringPropertyChangedEventArgs e)
    {
      Functions.CategoryLevel.GenerateName(_obj);
    }
  }

}