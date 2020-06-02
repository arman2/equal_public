using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Core.Types;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    [XmlInclude(typeof(HuaweiTestingSystem))]
    [XmlInclude(typeof(HuaweiTestingSystemStructure))]
    [XmlInclude(typeof(ResourcePool))]
    [XmlInclude(typeof(ResourcePoolStructure))]
    [XmlInclude(typeof(RunsOn))]
    [XmlInclude(typeof(RunsOnStructure))]
    [XmlInclude(typeof(TestScheduler))]
    [XmlInclude(typeof(TestSchedulerStructure))]
    [XmlInclude(typeof(Function))]
    [XmlInclude(typeof(FunctionStructure))]
    [XmlInclude(typeof(NextFunction))]
    [XmlInclude(typeof(NextFunctionStructure))]
    [XmlInclude(typeof(TestDefinition))]
    [XmlInclude(typeof(TestDefinitionStructure))]
    [XmlInclude(typeof(TestQueue))]
    [XmlInclude(typeof(TestQueueStructure))]
    [XmlInclude(typeof(TestFlow))]
    [XmlInclude(typeof(TestFlowStructure))]
    [XmlInclude(typeof(LocalVariable))]
    [XmlInclude(typeof(LocalVariableStructure))]
    [XmlInclude(typeof(HuaweiTestingMetaModelStructure))]

    public class HuaweiTestingMetaModelModel : DP_ModelType
    {
        public HuaweiTestingMetaModelModel()
        {
        }

        public HuaweiTestingMetaModelModel(string newName)
        {
            name = newName;
            Diagram = new HuaweiTestingMetaModelStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction init = new DP_AbstractText.Instruction();
            init.Name = "Initialize";
            init.String = "";
            Text.Instructions.Add(init);

        }

    }
}
