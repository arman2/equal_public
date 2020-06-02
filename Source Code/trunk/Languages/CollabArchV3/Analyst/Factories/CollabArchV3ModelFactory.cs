using System;
using System.IO;
using System.Xml.Serialization;
using DomainPro.Core.Types;
using DomainPro.Core.Interfaces;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Interfaces;
using Analyst.Types;

namespace Analyst.Factories
{
    public class CollabArchV3ModelFactory : DP_IModelFactory
    {
        public DP_AbstractModelType CreateModel()
        {
            return new CollabArchV3Model();
        }

        public void SaveModel(DP_AbstractModelType model, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CollabArchV3Model));
            TextWriter textWriter = new StreamWriter(path);
            serializer.Serialize(textWriter, model);
            textWriter.Close();
        }

        public DP_AbstractModelType LoadModel(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(CollabArchV3Model));
            TextReader textReader = new StreamReader(path);
            CollabArchV3Model model = (CollabArchV3Model)deserializer.Deserialize(textReader);
            textReader.Close();
            return model;
        }
    }
}
