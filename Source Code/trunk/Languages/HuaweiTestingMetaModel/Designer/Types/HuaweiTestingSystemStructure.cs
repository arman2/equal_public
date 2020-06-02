using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class HuaweiTestingSystemStructure : DP_Diagram
    {
        public HuaweiTestingSystemStructure()
        {
            availableShapes.Add("ResourcePool");
            availableShapes.Add("TestScheduler");

            availableLines.Add("RunsOn");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "ResourcePool")
            {
                ResourcePool newShape = new ResourcePool(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "TestScheduler")
            {
                TestScheduler newShape = new TestScheduler(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "RunsOn")
            {
                if (RunsOn.ValidRoles(src.Attached, dest.Attached))
                {
                    RunsOn newLine = new RunsOn(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
