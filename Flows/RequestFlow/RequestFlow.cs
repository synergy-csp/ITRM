using Bimser.Synergy.Entities.Workflow.EventArguments;
using System;
using Bimser.CSP.Runtime.Common.Extensions;
using System.Collections.Generic;
using Bimser.Synergy.ServiceAPI.Models.Form;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace ITRM.Flows
{
    public partial class RequestFlow
    {
        
   
		public void PositionGroup_OnAfterEvent(object sender,OnAfterEventArguments args)
		{
            if(args.EventCode == 18){
                var result=ServiceAPI.FormManager.Create("ITRM","ReviewerSelect",args.EventFormId).Result;
                ReviewerId.SetConstantValue(Convert.ToInt32(((List<object>)result.Controls["Reviewer"].Value).FirstOrDefault()));
                Document1.SetControlValue("ReviewReason",result.Controls["ReviewReason"].Value);
                Document1.SaveDocument().Wait();
            }
		}

		public void ManagerPosition_OnAfterEvent(object sender,OnAfterEventArguments args)
		{
            if(args.EventCode == 7 && Convert.ToInt32(Document1.FormInstance.GetControlValue(Document1.DocumentId,"OpenType").Result.ControlValue.ToString()) == 2){
                RequestorNotification.AddConstantUser(Convert.ToInt32(((List<object>)Document1.FormInstance.Controls["RequestorLook"].Value).FirstOrDefault()));
            }
		}
 }
}