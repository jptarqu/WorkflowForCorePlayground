Imports System.Activities
Imports System.Activities.Statements
Imports System.Diagnostics
Imports System.Linq

Module Module1

    Sub Main()
        Dim startTime = DateTime.Now


        Console.WriteLine(".net 4.8 run")
        Dim workflow1 = New Workflow1()
        WorkflowInvoker.Invoke(workflow1)
        Console.WriteLine("Duration: " & (DateTime.Now.Subtract(startTime).TotalSeconds))
        Console.ReadLine()


    End Sub

End Module
