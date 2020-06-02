using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class CollaboratorStructure : DP_Diagram
    {
        public CollaboratorStructure()
        {
            availableShapes.Add("Component");
            availableShapes.Add("Subscriber");
            availableShapes.Add("EventProcessor");
            availableShapes.Add("Publisher");
            availableShapes.Add("Connector");
            availableShapes.Add("PubSubDistributor");
            availableShapes.Add("Metric");
            availableShapes.Add("Icon");
            availableShapes.Add("MessageIcon");
            availableShapes.Add("StreamIcon");
            availableShapes.Add("ArtifactIcon");
            availableShapes.Add("Variable");

            availableLines.Add("CollabSequence");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Component")
            {
                Component newShape = new Component(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Subscriber")
            {
                Subscriber newShape = new Subscriber(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "EventProcessor")
            {
                EventProcessor newShape = new EventProcessor(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Publisher")
            {
                Publisher newShape = new Publisher(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Connector")
            {
                Connector newShape = new Connector(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "PubSubDistributor")
            {
                PubSubDistributor newShape = new PubSubDistributor(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Metric")
            {
                Metric newShape = new Metric(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Icon")
            {
                Icon newShape = new Icon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "MessageIcon")
            {
                MessageIcon newShape = new MessageIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "StreamIcon")
            {
                StreamIcon newShape = new StreamIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "ArtifactIcon")
            {
                ArtifactIcon newShape = new ArtifactIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Variable")
            {
                Variable newShape = new Variable(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "CollabSequence")
            {
                if (CollabSequence.ValidRoles(src.Attached, dest.Attached))
                {
                    CollabSequence newLine = new CollabSequence(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
