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
    [XmlInclude(typeof(Actor))]
    [XmlInclude(typeof(ActorStructure))]
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
    [XmlInclude(typeof(TriggerConnection))]
    [XmlInclude(typeof(TriggerConnectionStructure))]
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
    [XmlInclude(typeof(Message))]
    [XmlInclude(typeof(MessageStructure))]
    [XmlInclude(typeof(Stream))]
    [XmlInclude(typeof(StreamStructure))]
    [XmlInclude(typeof(Artifact))]
    [XmlInclude(typeof(ArtifactStructure))]
    [XmlInclude(typeof(TrigUpdated))]
    [XmlInclude(typeof(TrigUpdatedStructure))]
    [XmlInclude(typeof(TrigCreated))]
    [XmlInclude(typeof(TrigCreatedStructure))]
    [XmlInclude(typeof(TrigDeleted))]
    [XmlInclude(typeof(TrigDeletedStructure))]
    [XmlInclude(typeof(FocusedOn))]
    [XmlInclude(typeof(FocusedOnStructure))]
    [XmlInclude(typeof(TriggeredConnection))]
    [XmlInclude(typeof(TriggeredConnectionStructure))]
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
    [XmlInclude(typeof(KnowsUniDir))]
    [XmlInclude(typeof(KnowsUniDirStructure))]
    [XmlInclude(typeof(KnowsBiDir))]
    [XmlInclude(typeof(KnowsBiDirStructure))]
    [XmlInclude(typeof(Icon))]
    [XmlInclude(typeof(IconStructure))]
    [XmlInclude(typeof(StreamIcon))]
    [XmlInclude(typeof(StreamIconStructure))]
    [XmlInclude(typeof(ObjectIcon))]
    [XmlInclude(typeof(ObjectIconStructure))]
    [XmlInclude(typeof(MessageIcon))]
    [XmlInclude(typeof(MessageIconStructure))]
    [XmlInclude(typeof(ArtifactIcon))]
    [XmlInclude(typeof(ArtifactIconStructure))]
    [XmlInclude(typeof(CollabIcon))]
    [XmlInclude(typeof(CollabIconStructure))]
    [XmlInclude(typeof(ComponentIcon))]
    [XmlInclude(typeof(ComponentIconStructure))]
    [XmlInclude(typeof(ConnectorIcon))]
    [XmlInclude(typeof(ConnectorIconStructure))]
    [XmlInclude(typeof(ActionIcon))]
    [XmlInclude(typeof(ActionIconStructure))]
    [XmlInclude(typeof(ReadIcon))]
    [XmlInclude(typeof(ReadIconStructure))]
    [XmlInclude(typeof(DecideIcon))]
    [XmlInclude(typeof(DecideIconStructure))]
    [XmlInclude(typeof(WorkIcon))]
    [XmlInclude(typeof(WorkIconStructure))]
    [XmlInclude(typeof(IdleIcon))]
    [XmlInclude(typeof(IdleIconStructure))]
    [XmlInclude(typeof(CreateIcon))]
    [XmlInclude(typeof(CreateIconStructure))]
    [XmlInclude(typeof(UpdateIcon))]
    [XmlInclude(typeof(UpdateIconStructure))]
    [XmlInclude(typeof(DeleteIcon))]
    [XmlInclude(typeof(DeleteIconStructure))]
    [XmlInclude(typeof(WaitIcon))]
    [XmlInclude(typeof(WaitIconStructure))]
    [XmlInclude(typeof(CollabArchV3Structure))]

    public class CollabArchV3Model : DP_ModelType
    {
        public CollabArchV3Model()
        {
        }

        public CollabArchV3Model(string newName)
        {
            name = newName;
            Diagram = new CollabArchV3Structure();
            Text = new DP_Text();
            DP_AbstractText.Instruction init = new DP_AbstractText.Instruction();
            init.Name = "Initialize";
            init.String = "";
            Text.Instructions.Add(init);

        }

    }
}
