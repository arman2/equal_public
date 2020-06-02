using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Core.Types;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    [XmlInclude(typeof(SourceNode))]
    [XmlInclude(typeof(SourceNodeStructure))]
    [XmlInclude(typeof(TerminateNode))]
    [XmlInclude(typeof(TerminateNodeStructure))]
    [XmlInclude(typeof(DelayNode))]
    [XmlInclude(typeof(DelayNodeStructure))]
    [XmlInclude(typeof(FacilityNode))]
    [XmlInclude(typeof(FacilityNodeStructure))]
    [XmlInclude(typeof(QueueNode))]
    [XmlInclude(typeof(QueueNodeStructure))]
    [XmlInclude(typeof(AssignNode))]
    [XmlInclude(typeof(AssignNodeStructure))]
    [XmlInclude(typeof(ResourceQ))]
    [XmlInclude(typeof(ResourceQStructure))]
    [XmlInclude(typeof(GateQ))]
    [XmlInclude(typeof(GateQStructure))]
    [XmlInclude(typeof(SwitchNode))]
    [XmlInclude(typeof(SwitchNodeStructure))]
    [XmlInclude(typeof(MatchQ))]
    [XmlInclude(typeof(MatchQStructure))]
    [XmlInclude(typeof(GroupQ))]
    [XmlInclude(typeof(GroupQStructure))]
    [XmlInclude(typeof(UngroupNode))]
    [XmlInclude(typeof(UngroupNodeStructure))]
    [XmlInclude(typeof(ResourceStock))]
    [XmlInclude(typeof(ResourceStockStructure))]
    [XmlInclude(typeof(Procedure))]
    [XmlInclude(typeof(ProcedureStructure))]
    [XmlInclude(typeof(QueueingTheoryMetamodelStructure))]

    public class QueueingTheoryMetamodelModel : DP_ModelType
    {
        public QueueingTheoryMetamodelModel()
        {
        }

        public QueueingTheoryMetamodelModel(string newName)
        {
            name = newName;
            Diagram = new QueueingTheoryMetamodelStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction init = new DP_AbstractText.Instruction();
            init.Name = "Initialize";
            init.String = "";
            Text.Instructions.Add(init);

        }

    }
}
