using System;
using System.Activities;
using System.Activities.XamlIntegration;
using System.Collections.Generic;
using System.IO;

namespace WorkflowFuncHelper
{
    public static class Helper
    {
        public static int RunWorkflow()
        {
            string xamlString = XamlDataProvider.GetXaml();
            var activity = ActivityXamlServices.Load(new StringReader(xamlString), new ActivityXamlServicesSettings { CompileExpressions = true });
            var resultDict = WorkflowInvoker.Invoke(activity, new Dictionary<string, Object>());
            var endingNumber = (int)resultDict["DesiredNumberResult"];
            return endingNumber;
        }
    }
}
