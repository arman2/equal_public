using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Analyst.Types;

namespace Analyst.Types
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

    }
}
