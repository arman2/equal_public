using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class MyQueueingModelStructure : DP_Diagram
    {
        public MyQueueingModelStructure()
        {
            availableShapes.Add("MyStep");
            availableShapes.Add("MySource");
            availableShapes.Add("MyDestination");

            availableLines.Add("MyFlow");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "MyStep")
            {
                MyStep newShape = new MyStep(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "MySource")
            {
                MySource newShape = new MySource(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "MyDestination")
            {
                MyDestination newShape = new MyDestination(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "MyFlow")
            {
                if (MyFlow.ValidRoles(src.Attached, dest.Attached))
                {
                    MyFlow newLine = new MyFlow(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
