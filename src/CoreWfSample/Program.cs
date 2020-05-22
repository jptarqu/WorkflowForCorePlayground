﻿using System;
using System.IO;
using System.Activities;
using System.Activities.XamlIntegration;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace CoreWfSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CoreWF run");
               var xamlString = File.ReadAllText("sampleXaml.xml");
            var startTime = DateTime.Now;
            var activity = ActivityXamlServices.Load(new StringReader(xamlString), new ActivityXamlServicesSettings { CompileExpressions = true });
            WorkflowInvoker.Invoke(activity, new Dictionary<string, Object>());
            Console.WriteLine("Duration: " + (DateTime.Now.Subtract(startTime).TotalSeconds));
            Console.ReadLine();
        }
    }
}
