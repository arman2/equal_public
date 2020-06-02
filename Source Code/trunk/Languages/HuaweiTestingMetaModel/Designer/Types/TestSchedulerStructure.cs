using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class TestSchedulerStructure : DP_Diagram
    {
        public TestSchedulerStructure()
        {
            availableShapes.Add("TestDefinition");
            availableShapes.Add("Function");
            availableShapes.Add("TestQueue");

            availableLines.Add("NextFunction");
            availableLines.Add("TestFlow");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "TestDefinition")
            {
                TestDefinition newShape = new TestDefinition(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Function")
            {
                Function newShape = new Function(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "TestQueue")
            {
                TestQueue newShape = new TestQueue(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "NextFunction")
            {
                if (NextFunction.ValidRoles(src.Attached, dest.Attached))
                {
                    NextFunction newLine = new NextFunction(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "TestFlow")
            {
                if (TestFlow.ValidRoles(src.Attached, dest.Attached))
                {
                    TestFlow newLine = new TestFlow(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
