using System;

namespace DesignPattern.Structural.Adapter.Concept
{
    enum DataType
    {
        XML,
        JSON
    }

    public class XmlClient
    {
        public XmlClient(XmlType type);
    }

    public class XmlType
    {
        private DataType _type;
        public XmlType(DataType type)
        {
            _type = type;
        }

        public string getType()
        {
            return "Datatype is : " + _type.ToString();
        }
    }

    public class JsonService
    {
        public JsonService(JsonType type);
    }

    public class JsonType
    {
        private DataType _type;
        public JsonType(DataType type)
        {
            _type = type;
        }

        public string getType()
        {
            return "Datatype is : " + _type.ToString();
        }
    }

    public class JsonTypeAdapter : JsonType
    {
        private readonly XmlType _adaptee;

        public JsonTypeAdapter(XmlType type)
        {
            _adaptee = type;
        }

        public override string getType()
        {
            var jsonType = (_adaptee.getType() == "DataType.XML") ? new JsonType(DataType.JSON) : "";
            return "Changed Datatype is : " + jsonType.getType();
        }
    }

    public static class Program
    {
        public static void main(string[] args)
        {
            // creating client object
            var xmlType = new XmlType(DataType.XML);
            var client = new XmlClient(xmlType);

            // simply passing default jsonType to service
            var jsonType = new JsonType(DataType.JSON);
            var service = new JsonService(jsonType);

            // placed an addapter and convert xmlType to AdaptedJsonType;
            var adapter = new JsonTypeAdapter(xmlType);
            var newService = new JsonService(adapter);
        }
    }
}