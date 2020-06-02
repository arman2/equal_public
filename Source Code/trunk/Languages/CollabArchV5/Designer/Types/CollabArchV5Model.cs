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
    [XmlInclude(typeof(CollabObject))]
    [XmlInclude(typeof(CollabObjectStructure))]
    [XmlInclude(typeof(Component))]
    [XmlInclude(typeof(ComponentStructure))]
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
    [XmlInclude(typeof(Variable))]
    [XmlInclude(typeof(VariableStructure))]
    [XmlInclude(typeof(Trigger))]
    [XmlInclude(typeof(TriggerStructure))]
    [XmlInclude(typeof(TriggerFlow))]
    [XmlInclude(typeof(TriggerFlowStructure))]
    [XmlInclude(typeof(ObjectData))]
    [XmlInclude(typeof(ObjectDataStructure))]
    [XmlInclude(typeof(ObjectMetadata))]
    [XmlInclude(typeof(ObjectMetadataStructure))]
    [XmlInclude(typeof(CollabSequence))]
    [XmlInclude(typeof(CollabSequenceStructure))]
    [XmlInclude(typeof(Collaborator))]
    [XmlInclude(typeof(CollaboratorStructure))]
    [XmlInclude(typeof(ObjectRefConnection))]
    [XmlInclude(typeof(ObjectRefConnectionStructure))]
    [XmlInclude(typeof(ConnProperty))]
    [XmlInclude(typeof(ConnPropertyStructure))]
    [XmlInclude(typeof(TriggerRefConn))]
    [XmlInclude(typeof(TriggerRefConnStructure))]
    [XmlInclude(typeof(TriggerDataSet))]
    [XmlInclude(typeof(TriggerDataSetStructure))]
    [XmlInclude(typeof(DataTransfer))]
    [XmlInclude(typeof(DataTransferStructure))]
    [XmlInclude(typeof(CollabStep))]
    [XmlInclude(typeof(CollabStepStructure))]
    [XmlInclude(typeof(Role))]
    [XmlInclude(typeof(RoleStructure))]
    [XmlInclude(typeof(Connector))]
    [XmlInclude(typeof(ConnectorStructure))]
    [XmlInclude(typeof(Metric))]
    [XmlInclude(typeof(MetricStructure))]
    [XmlInclude(typeof(KnowsConn))]
    [XmlInclude(typeof(KnowsConnStructure))]
    [XmlInclude(typeof(FocusOnObjConn))]
    [XmlInclude(typeof(FocusOnObjConnStructure))]
    [XmlInclude(typeof(MessageIcon))]
    [XmlInclude(typeof(MessageIconStructure))]
    [XmlInclude(typeof(StreamIcon))]
    [XmlInclude(typeof(StreamIconStructure))]
    [XmlInclude(typeof(ArtifactIcon))]
    [XmlInclude(typeof(ArtifactIconStructure))]
    [XmlInclude(typeof(Crowd))]
    [XmlInclude(typeof(CrowdStructure))]
    [XmlInclude(typeof(CrowdDep))]
    [XmlInclude(typeof(CrowdDepStructure))]
    [XmlInclude(typeof(Icon))]
    [XmlInclude(typeof(IconStructure))]
    [XmlInclude(typeof(IntraTriggerFlow))]
    [XmlInclude(typeof(IntraTriggerFlowStructure))]
    [XmlInclude(typeof(Subscriber))]
    [XmlInclude(typeof(SubscriberStructure))]
    [XmlInclude(typeof(PubSubDistributor))]
    [XmlInclude(typeof(PubSubDistributorStructure))]
    [XmlInclude(typeof(EventProcessor))]
    [XmlInclude(typeof(EventProcessorStructure))]
    [XmlInclude(typeof(Publisher))]
    [XmlInclude(typeof(PublisherStructure))]
    [XmlInclude(typeof(CollabArchV5Structure))]

    public class CollabArchV5Model : DP_ModelType
    {
        public CollabArchV5Model()
        {
        }

        public CollabArchV5Model(string newName)
        {
            name = newName;
            Diagram = new CollabArchV5Structure();
            Text = new DP_Text();
            DP_AbstractText.Instruction init = new DP_AbstractText.Instruction();
            init.Name = "Initialize";
            init.String = "";
            Text.Instructions.Add(init);

        }

    }
}
