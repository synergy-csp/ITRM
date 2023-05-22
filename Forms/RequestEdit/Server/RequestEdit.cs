using System;
using System.Collections.Generic;
using Bimser.CSP.FormControls.Common;
using Bimser.CSP.FormControls.Controls;
using Bimser.CSP.FormControls.Events;
using ITRM.Entities;
using Bimser.CSP.Runtime.Common.Extensions;
using Bimser.Synergy.Entities.Workflow.Runtime.Models.Controller;
using Newtonsoft.Json.Linq;

namespace ITRM.Forms {

    public partial class RequestEdit {

   
		void RequestEdit_OnLoad(object sender, LoadEventArgs e)
		{
            if(ResponseParameters.TryGetValue("workflowInfo", out object workflowObject)){
                WorkflowInfo workflowInfo = ((JObject)workflowObject).ToObject<WorkflowInfo>();
                Caption.Text.SetText(workflowInfo.FlowStatusCaptions.GetValueOrDefault(Session.Language) ?? "Yeni Talep");
            }
		}
 }
}