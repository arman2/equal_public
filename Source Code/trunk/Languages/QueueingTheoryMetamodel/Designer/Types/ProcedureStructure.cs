using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class ProcedureStructure : DP_Diagram
    {
        public ProcedureStructure()
        {
            availableShapes.Add("SourceNode");
            availableShapes.Add("TerminateNode");
            availableShapes.Add("AssignNode");
            availableShapes.Add("FacilityNode");
            availableShapes.Add("ResourceStock");
            availableShapes.Add("QueueNode");
            availableShapes.Add("GateQ");
            availableShapes.Add("MatchQ");
            availableShapes.Add("ResourceQ");
            availableShapes.Add("GroupQ");
            availableShapes.Add("SwitchNode");
            availableShapes.Add("DelayNode");


        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "SourceNode")
            {
                SourceNode newShape = new SourceNode(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "TerminateNode")
            {
                TerminateNode newShape = new TerminateNode(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "AssignNode")
            {
                AssignNode newShape = new AssignNode(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "FacilityNode")
            {
                FacilityNode newShape = new FacilityNode(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "ResourceStock")
            {
                ResourceStock newShape = new ResourceStock(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "QueueNode")
            {
                QueueNode newShape = new QueueNode(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "GateQ")
            {
                GateQ newShape = new GateQ(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "MatchQ")
            {
                MatchQ newShape = new MatchQ(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "ResourceQ")
            {
                ResourceQ newShape = new ResourceQ(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "GroupQ")
            {
                GroupQ newShape = new GroupQ(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "SwitchNode")
            {
                SwitchNode newShape = new SwitchNode(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "DelayNode")
            {
                DelayNode newShape = new DelayNode(startLocation);
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
