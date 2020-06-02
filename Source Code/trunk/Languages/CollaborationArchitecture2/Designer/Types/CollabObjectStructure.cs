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

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            return null;
        }

    }
}
