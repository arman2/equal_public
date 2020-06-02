using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class CollabPatternStructure : DP_Diagram
    {
        public CollabPatternStructure()
        {
            availableShapes.Add("Connector");
            availableShapes.Add("Actor");
            availableShapes.Add("CollabObject");
            availableShapes.Add("Message");
            availableShapes.Add("Stream");
            availableShapes.Add("Artifact");

            availableLines.Add("TriggerConnection");
            availableLines.Add("ObjectRefConnection");
            availableLines.Add("FocusedOn");
            availableLines.Add("TriggeredConnection");
            availableLines.Add("CollabSequence");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Connector")
            {
                Connector newShape = new Connector(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Actor")
            {
                Actor newShape = new Actor(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "CollabObject")
            {
                CollabObject newShape = new CollabObject(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Message")
            {
                Message newShape = new Message(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Stream")
            {
                Stream newShape = new Stream(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Artifact")
            {
                Artifact newShape = new Artifact(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "TriggerConnection")
            {
                if (TriggerConnection.ValidRoles(src.Attached, dest.Attached))
                {
                    TriggerConnection newLine = new TriggerConnection(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "ObjectRefConnection")
            {
                if (ObjectRefConnection.ValidRoles(src.Attached, dest.Attached))
                {
                    ObjectRefConnection newLine = new ObjectRefConnection(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "FocusedOn")
            {
                if (FocusedOn.ValidRoles(src.Attached, dest.Attached))
                {
                    FocusedOn newLine = new FocusedOn(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "TriggeredConnection")
            {
                if (TriggeredConnection.ValidRoles(src.Attached, dest.Attached))
                {
                    TriggeredConnection newLine = new TriggeredConnection(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

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
