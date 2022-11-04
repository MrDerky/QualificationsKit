using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using starkov.Qualifications.CompetenceModel;

namespace starkov.Qualifications
{
  partial class CompetenceModelSharedHandlers
  {

    public virtual void JobTitleChanged(starkov.Qualifications.Shared.CompetenceModelJobTitleChangedEventArgs e)
    {
      Functions.CompetenceModel.GenerateName(_obj);
    }

    public virtual void LevelChanged(starkov.Qualifications.Shared.CompetenceModelLevelChangedEventArgs e)
    {
      Functions.CompetenceModel.GenerateName(_obj);
    }

  }
}