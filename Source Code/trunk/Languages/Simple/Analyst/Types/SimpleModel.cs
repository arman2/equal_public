using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Analyst.Types;

namespace Analyst.Types
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

    }
}
