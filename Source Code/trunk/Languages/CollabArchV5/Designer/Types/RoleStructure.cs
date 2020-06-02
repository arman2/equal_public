using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class RoleStructure : DP_Diagram
    {
        public RoleStructure()
        {
            availableShapes.Add("Create");
            availableShapes.Add("Read");
            availableShapes.Add("Update");
            availableShapes.Add("Delete");
            availableShapes.Add("Work");
            availableShapes.Add("Variable");
            availableShapes.Add("DataTransfer");
            availableShapes.Add("Icon");
            availableShapes.Add("MessageIcon");
            availableShapes.Add("StreamIcon");
            availableShapes.Add("ArtifactIcon");
            availableShapes.Add("Metric");

            availableLines.Add("CollabSequence");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Create")
            {
                Create newShape = new Create(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Read")
            {
                Read newShape = new Read(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Update")
            {
                Update newShape = new Update(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Delete")
            {
                Delete newShape = new Delete(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Work")
            {
                Work newShape = new Work(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Variable")
            {
                Variable newShape = new Variable(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "DataTransfer")
            {
                DataTransfer newShape = new DataTransfer(startLocation);
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

            if (shapeType == "Metric")
            {
                Metric newShape = new Metric(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
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
