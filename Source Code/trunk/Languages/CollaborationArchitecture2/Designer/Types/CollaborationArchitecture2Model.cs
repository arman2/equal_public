using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Core.Types;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    [XmlInclude(typeof(CollabPattern))]
    [XmlInclude(typeof(CollabPatternStructure))]
    [XmlInclude(typeof(Collaborator))]
    [XmlInclude(typeof(CollaboratorStructure))]
    [XmlInclude(typeof(CollabObject))]
    [XmlInclude(typeof(CollabObjectStructure))]
    [XmlInclude(typeof(CollabStep))]
    [XmlInclude(typeof(CollabStepStructure))]
    [XmlInclude(typeof(CollabConnection))]
    [XmlInclude(typeof(CollabConnectionStructure))]
    [XmlInclude(typeof(Actor))]
    [XmlInclude(typeof(ActorStructure))]
    [XmlInclude(typeof(Connector))]
    [XmlInclude(typeof(ConnectorStructure))]
    [XmlInclude(typeof(CollabAction))]
    [XmlInclude(typeof(CollabActionStructure))]
    [XmlInclude(typeof(Create))]
    [XmlInclude(typeof(CreateStructure))]
    [XmlInclude(typeof(Read))]
    [XmlInclude(typeof(ReadStructure))]
    [XmlInclude(typeof(Update))]
    [XmlInclude(typeof(UpdateStructure))]
    [XmlInclude(typeof(Delete))]
    [XmlInclude(typeof(DeleteStructure))]
    [XmlInclude(typeof(Work))]
    [XmlInclude(typeof(WorkStructure))]
    [XmlInclude(typeof(Decison))]
    [XmlInclude(typeof(DecisonStructure))]
    [XmlInclude(typeof(Variable))]
    [XmlInclude(typeof(VariableStructure))]
    [XmlInclude(typeof(CollabMetric))]
    [XmlInclude(typeof(CollabMetricStructure))]
    [XmlInclude(typeof(Trigger))]
    [XmlInclude(typeof(TriggerStructure))]
    [XmlInclude(typeof(TriggerConnection))]
    [XmlInclude(typeof(TriggerConnectionStructure))]
    [XmlInclude(typeof(ObjectData))]
    [XmlInclude(typeof(ObjectDataStructure))]
    [XmlInclude(typeof(ObjectMetadata))]
    [XmlInclude(typeof(ObjectMetadataStructure))]
    [XmlInclude(typeof(ActorPool))]
    [XmlInclude(typeof(ActorPoolStructure))]
    [XmlInclude(typeof(CollabSequence))]
    [XmlInclude(typeof(CollabSequenceStructure))]
    [XmlInclude(typeof(CollaborationArchitecture2Structure))]

    public class CollaborationArchitecture2Model : DP_ModelType
    {
        public CollaborationArchitecture2Model()
        {
        }

        public CollaborationArchitecture2Model(string newName)
        {
            name = newName;
            Diagram = new CollaborationArchitecture2Structure();
            Text = new DP_Text();
            DP_AbstractText.Instruction init = new DP_AbstractText.Instruction();
            init.Name = "Initialize";
            init.String = "";
            Text.Instructions.Add(init);

        }

    }
}
