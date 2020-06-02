using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class CollabPatternStructure : DP_Diagram
    {
        public CollabPatternStructure()
        {
            availableShapes.Add("Actor");
            availableShapes.Add("Connector");
            availableShapes.Add("CollabObject");

            availableLines.Add("CollabConnection");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Actor")
            {
                Actor newShape = new Actor(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Connector")
            {
                Connector newShape = new Connector(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "CollabObject")
            {
                CollabObject newShape = new CollabObject(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "CollabConnection")
            {
                if (CollabConnection.ValidRoles(src.Attached, dest.Attached))
                {
                    CollabConnection newLine = new CollabConnection(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
