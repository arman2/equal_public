using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class CollabObjectStructure : DP_Diagram
    {
        public CollabObjectStructure()
        {
            availableShapes.Add("Trigger");
            availableShapes.Add("ObjectMetadata");
            availableShapes.Add("ObjectData");
            availableShapes.Add("TriggerDataSet");
            availableShapes.Add("Icon");
            availableShapes.Add("MessageIcon");
            availableShapes.Add("StreamIcon");
            availableShapes.Add("ArtifactIcon");

            availableLines.Add("IntraTriggerFlow");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Trigger")
            {
                Trigger newShape = new Trigger(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "ObjectMetadata")
            {
                ObjectMetadata newShape = new ObjectMetadata(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "ObjectData")
            {
                ObjectData newShape = new ObjectData(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "TriggerDataSet")
            {
                TriggerDataSet newShape = new TriggerDataSet(startLocation);
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

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "IntraTriggerFlow")
            {
                if (IntraTriggerFlow.ValidRoles(src.Attached, dest.Attached))
                {
                    IntraTriggerFlow newLine = new IntraTriggerFlow(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
