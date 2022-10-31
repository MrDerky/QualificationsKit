using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using starkov.Qualifications.CompetenceModel;

namespace starkov.Qualifications.Server
{
  partial class CompetenceModelFunctions
  {

    /// <summary>
    /// Получить схему модели компетенций для должности.
    /// </summary>       
    [Remote]
    public StateView GetCompetenceModelState()
    {
      var stateView = StateView.Create();
      return stateView;
    }

  }
}