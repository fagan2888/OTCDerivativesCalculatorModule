using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.IO;
using CppCodeGen;

namespace TestConsole
{
    class Program
    {
        public const string rootFolder = @"D:\fpml\confirmation\";

        static void Main(string[] args)
        {

            XmlSchema rootSchema = GetSchemaFromFile("fpml-ird-5-4.xsd");
            using (var writer = new StringWriter())
            {
                
                foreach (XmlSchemaObject item in rootSchema.Items)
                {
                    if (item is XmlSchemaElement)
                    {
                        XmlSchemaElement xe = item as XmlSchemaElement;
                    }
                    else if (item is XmlSchemaComplexType)
                    {
                        XmlSchemaComplexType xsct = item as XmlSchemaComplexType;
                        CppCodeGen.Generator gen = new Generator(xsct);
                        gen.makeCode();
                        writer.WriteLine(gen.Code);
                        
    
                    }
                 }

            File.WriteAllText(Path.Combine(rootFolder, "genCode.hpp"), writer.GetStringBuilder().ToString());

            }
        }
            

        
        private static XmlSchema GetSchemaFromFile(string fileName)
        {
            using (var fs = new FileStream(Path.Combine(rootFolder, fileName), FileMode.Open))
                return XmlSchema.Read(fs, null);
        }

    }
}
