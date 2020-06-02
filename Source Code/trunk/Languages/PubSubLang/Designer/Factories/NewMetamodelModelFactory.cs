using System;
using System.IO;
using System.Xml.Serialization;
using DomainPro.Core.Types;
using DomainPro.Core.Interfaces;
using DomainPro.Designer.Types;
using DomainPro.Designer.Interfaces;
using Designer.Types;

namespace Designer.Factories
{
    public class NewMetamodelModelFactory : DP_IModelFactory
    {
        public DP_AbstractModelType CreateModel()
        {
            return new NewMetamodelModel("NewNewMetamodel");
        }

        public void SaveModel(DP_AbstractModelType model, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(NewMetamodelModel));
            TextWriter textWriter = new StreamWriter(path);
            serializer.Serialize(textWriter, model);
            textWriter.Close();
        }

        public DP_AbstractModelType LoadModel(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(NewMetamodelModel));
            TextReader textReader = new StreamReader(path);
            NewMetamodelModel model = (NewMetamodelModel)deserializer.Deserialize(textReader);
            textReader.Close();
            return model;
        }
    }
}
