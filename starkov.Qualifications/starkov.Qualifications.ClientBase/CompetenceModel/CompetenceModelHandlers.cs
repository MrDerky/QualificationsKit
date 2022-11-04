using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using starkov.Qualifications.CompetenceModel;

namespace starkov.Qualifications
{
  partial class CompetenceModelClientHandlers
  {

    public override void Showing(Sungero.Presentation.FormShowingEventArgs e)
    {
      if (_obj.Icon == null)
        _obj.State.Properties.Icon.IsVisible = false;
    }

  }
}