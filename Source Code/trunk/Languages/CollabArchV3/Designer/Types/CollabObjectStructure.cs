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
            availableShapes.Add("TrigUpdated");
            availableShapes.Add("TrigCreated");
            availableShapes.Add("TrigDeleted");
            availableShapes.Add("ObjectMetadata");
            availableShapes.Add("ObjectData");
            availableShapes.Add("TriggerDataSet");
            availableShapes.Add("StreamIcon");
            availableShapes.Add("MessageIcon");
            availableShapes.Add("ArtifactIcon");


        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Trigger")
            {
                Trigger newShape = new Trigger(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "TrigUpdated")
            {
                TrigUpdated newShape = new TrigUpdated(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "TrigCreated")
            {
                TrigCreated newShape = new TrigCreated(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "TrigDeleted")
            {
                TrigDeleted newShape = new TrigDeleted(startLocation);
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

            if (shapeType == "StreamIcon")
            {
                StreamIcon newShape = new StreamIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "MessageIcon")
            {
                MessageIcon newShape = new MessageIcon(startLocation);
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
            return null;
        }

    }
}
