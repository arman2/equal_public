using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Core.Types;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    [XmlInclude(typeof(PubSubEnv))]
    [XmlInclude(typeof(PubSubEnvStructure))]
    [XmlInclude(typeof(Publisher))]
    [XmlInclude(typeof(PublisherStructure))]
    [XmlInclude(typeof(Subscriber))]
    [XmlInclude(typeof(SubscriberStructure))]
    [XmlInclude(typeof(Peer))]
    [XmlInclude(typeof(PeerStructure))]
    [XmlInclude(typeof(Action))]
    [XmlInclude(typeof(ActionStructure))]
    [XmlInclude(typeof(Subscribe))]
    [XmlInclude(typeof(SubscribeStructure))]
    [XmlInclude(typeof(Publish))]
    [XmlInclude(typeof(PublishStructure))]
    [XmlInclude(typeof(Group))]
    [XmlInclude(typeof(GroupStructure))]
    [XmlInclude(typeof(Receive))]
    [XmlInclude(typeof(ReceiveStructure))]
    [XmlInclude(typeof(Forward))]
    [XmlInclude(typeof(ForwardStructure))]
    [XmlInclude(typeof(PubStream))]
    [XmlInclude(typeof(PubStreamStructure))]
    [XmlInclude(typeof(SubStream))]
    [XmlInclude(typeof(SubStreamStructure))]
    [XmlInclude(typeof(Event))]
    [XmlInclude(typeof(EventStructure))]
    [XmlInclude(typeof(NewMetamodelStructure))]

    public class NewMetamodelModel : DP_ModelType
    {
        public NewMetamodelModel()
        {
        }

        public NewMetamodelModel(string newName)
        {
            name = newName;
            Diagram = new NewMetamodelStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction init = new DP_AbstractText.Instruction();
            init.Name = "Initialize";
            init.String = "";
            Text.Instructions.Add(init);

        }

    }
}
