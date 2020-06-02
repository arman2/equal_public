using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Core.Types;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    [XmlInclude(typeof(InputGenerator))]
    [XmlInclude(typeof(InputGeneratorStructure))]
    [XmlInclude(typeof(Processor))]
    [XmlInclude(typeof(ProcessorStructure))]
    [XmlInclude(typeof(RunsOn))]
    [XmlInclude(typeof(RunsOnStructure))]
    [XmlInclude(typeof(Function))]
    [XmlInclude(typeof(FunctionStructure))]
    [XmlInclude(typeof(Container))]
    [XmlInclude(typeof(ContainerStructure))]
    [XmlInclude(typeof(SimpleStructure))]

    public class SimpleModel : DP_ModelType
    {
        public SimpleModel()
        {
        }

        public SimpleModel(string newName)
        {
            name = newName;
            Diagram = new SimpleStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction init = new DP_AbstractText.Instruction();
            init.Name = "Initialize";
            init.String = "";
            Text.Instructions.Add(init);

        }

    }
}
