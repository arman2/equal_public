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
            availableShapes.Add("ReadIcon");
            availableShapes.Add("DecideIcon");
            availableShapes.Add("DeleteIcon");
            availableShapes.Add("UpdateIcon");
            availableShapes.Add("CreateIcon");
            availableShapes.Add("WorkIcon");
            availableShapes.Add("IdleIcon");
            availableShapes.Add("WaitIcon");


        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Variable")
            {
                Variable newShape = new Variable(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "ReadIcon")
            {
                ReadIcon newShape = new ReadIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "DecideIcon")
            {
                DecideIcon newShape = new DecideIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "DeleteIcon")
            {
                DeleteIcon newShape = new DeleteIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "UpdateIcon")
            {
                UpdateIcon newShape = new UpdateIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "CreateIcon")
            {
                CreateIcon newShape = new CreateIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "WorkIcon")
            {
                WorkIcon newShape = new WorkIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "IdleIcon")
            {
                IdleIcon newShape = new IdleIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "WaitIcon")
            {
                WaitIcon newShape = new WaitIcon(startLocation);
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
