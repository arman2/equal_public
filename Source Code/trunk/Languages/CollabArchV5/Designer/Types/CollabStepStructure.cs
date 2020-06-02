using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class CollabStepStructure : DP_Diagram
    {
        public CollabStepStructure()
        {
            availableShapes.Add("Variable");
            availableShapes.Add("Icon");
            availableShapes.Add("MessageIcon");
            availableShapes.Add("StreamIcon");
            availableShapes.Add("ArtifactIcon");


        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Variable")
            {
                Variable newShape = new Variable(startLocation);
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
            return null;
        }

    }
}
