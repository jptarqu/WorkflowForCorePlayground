using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFuncSample
{
    internal static class XamlDataProvider
    {
        internal static string GetXaml()
        {
            return @"<Activity mc:Ignorable=""sap sap2010 sads"" x:Class=""Workflow1""
 xmlns=""http://schemas.microsoft.com/netfx/2009/xaml/activities""
 xmlns:mc=""http://schemas.openxmlformats.org/markup-compatibility/2006""
 xmlns:sads=""http://schemas.microsoft.com/netfx/2010/xaml/activities/debugger""
 xmlns:sap=""http://schemas.microsoft.com/netfx/2009/xaml/activities/presentation""
 xmlns:sap2010=""http://schemas.microsoft.com/netfx/2010/xaml/activities/presentation""
 xmlns:scg=""clr-namespace:System.Collections.Generic;assembly=mscorlib""
 xmlns:sco=""clr-namespace:System.Collections.ObjectModel;assembly=mscorlib""
 xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
  <x:Members>
    <x:Property Name=""DesiredNumberResult"" Type=""OutArgument(x:Int32)"" />
  </x:Members>
  <sap2010:WorkflowViewState.IdRef>Workflow1_1</sap2010:WorkflowViewState.IdRef>
  <TextExpression.NamespacesForImplementation>
    <sco:Collection x:TypeArguments=""x:String"">
      <x:String>System</x:String>
      <x:String>System.Collections.Generic</x:String>
      <x:String>System.Data</x:String>
      <x:String>System.Linq</x:String>
      <x:String>System.Text</x:String>
      <x:String>System.Activities</x:String>
    </sco:Collection>
  </TextExpression.NamespacesForImplementation>
  <TextExpression.ReferencesForImplementation>
    <sco:Collection x:TypeArguments=""AssemblyReference"">
      <AssemblyReference>mscorlib</AssemblyReference>
      <AssemblyReference>System</AssemblyReference>
      <AssemblyReference>System.Core</AssemblyReference>
      <AssemblyReference>System.Data</AssemblyReference>
      <AssemblyReference>System.ServiceModel</AssemblyReference>
      <AssemblyReference>System.Xml</AssemblyReference>
      <AssemblyReference>System.Activities</AssemblyReference>
    </sco:Collection>
  </TextExpression.ReferencesForImplementation>
  <Sequence sap2010:WorkflowViewState.IdRef=""Sequence_1"">
    <Sequence.Variables>
      <Variable x:TypeArguments=""x:Int32"" Default=""1"" Name=""desiredNumber"" />
    </Sequence.Variables>
    <Assign sap2010:WorkflowViewState.IdRef=""Assign_1"">
      <Assign.To>
        <OutArgument x:TypeArguments=""x:Int32"">[desiredNumber]</OutArgument>
      </Assign.To>
      <Assign.Value>
        <InArgument x:TypeArguments=""x:Int32"">[desiredNumber * 2]</InArgument>
      </Assign.Value>
    </Assign>
    <WriteLine sap2010:WorkflowViewState.IdRef=""WriteLine_1"" Text=""[desiredNumber.ToString()]"" />
    <While sap2010:WorkflowViewState.IdRef=""While_1"" Condition=""[desiredNumber &lt; 50]"">
      <Sequence sap2010:WorkflowViewState.IdRef=""Sequence_2"">
        <Assign sap2010:WorkflowViewState.IdRef=""Assign_2"">
          <Assign.To>
            <OutArgument x:TypeArguments=""x:Int32"">[desiredNumber]</OutArgument>
          </Assign.To>
          <Assign.Value>
            <InArgument x:TypeArguments=""x:Int32"">[desiredNumber + 2]</InArgument>
          </Assign.Value>
        </Assign>
        <WriteLine sap2010:WorkflowViewState.IdRef=""WriteLine_2"" Text=""[&quot;New number &quot; &amp; desiredNumber.ToString()]"" />
      </Sequence>
    </While>
    <Assign sap2010:WorkflowViewState.IdRef=""Assign_3"">
      <Assign.To>
        <OutArgument x:TypeArguments=""x:Int32"">[DesiredNumberResult]</OutArgument>
      </Assign.To>
      <Assign.Value>
        <InArgument x:TypeArguments=""x:Int32"">[desiredNumber]</InArgument>
      </Assign.Value>
    </Assign>
    <sads:DebugSymbol.Symbol>d1hDOlxTb3VyY2VzXHB1YmxpY1xXb3JrZmxvd0ZvckNvcmVQbGF5Z3JvdW5kXHNyY1xXb3JrZmxvd0ZvckNvcmVQbGF5Z3JvdW5kXFdvcmtmbG93MS54YW1sEiMDRg4CAQElMyU2AgECJwUuDgIBFy8FL2ICARQwBTwNAgEIPQVEDgIBAywvLEICARopMCk/AgEYL0MvXwIBFTEHOxICAQswQDBZAgEJQi9CPgIBBj8wP0UCAQQyCTkSAgEPOgk6hAECAQw3MzdGAgESNDQ0QwIBEDpHOoEBAgEN</sads:DebugSymbol.Symbol>
  </Sequence>
  <sap2010:WorkflowViewState.ViewStateManager>
    <sap2010:ViewStateManager>
      <sap2010:ViewStateData Id=""Assign_1"" sap:VirtualizedContainerService.HintSize=""464,60"" />
      <sap2010:ViewStateData Id=""WriteLine_1"" sap:VirtualizedContainerService.HintSize=""464,61"" />
      <sap2010:ViewStateData Id=""Assign_2"" sap:VirtualizedContainerService.HintSize=""242,60"" />
      <sap2010:ViewStateData Id=""WriteLine_2"" sap:VirtualizedContainerService.HintSize=""242,61"" />
      <sap2010:ViewStateData Id=""Sequence_2"" sap:VirtualizedContainerService.HintSize=""264,285"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <x:Boolean x:Key=""IsExpanded"">True</x:Boolean>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""While_1"" sap:VirtualizedContainerService.HintSize=""464,443"" />
      <sap2010:ViewStateData Id=""Assign_3"" sap:VirtualizedContainerService.HintSize=""464,60"" />
      <sap2010:ViewStateData Id=""Sequence_1"" sap:VirtualizedContainerService.HintSize=""486,868"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <x:Boolean x:Key=""IsExpanded"">True</x:Boolean>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""Workflow1_1"" sap:VirtualizedContainerService.HintSize=""526,948"" />
    </sap2010:ViewStateManager>
  </sap2010:WorkflowViewState.ViewStateManager>
</Activity>";
        }
    }
}
