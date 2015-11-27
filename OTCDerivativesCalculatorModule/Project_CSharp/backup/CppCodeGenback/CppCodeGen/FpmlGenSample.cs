using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.CSharp;

namespace ConsoleApplication1
{
    internal class Program
    {
        public const string rootFolder = @"C:\FpML\xml\";

        private static void Main(string[] args)
        {
            XmlSchema rootSchema = GetSchemaFromFile("fpml-main-4-2.xsd");

            var schemaSet = new List<XmlSchemaExternal>();

            ExtractIncludes(rootSchema, ref schemaSet);

            var schemas = new XmlSchemas { rootSchema };

            schemaSet.ForEach(schemaExternal => schemas.Add(GetSchemaFromFile(schemaExternal.SchemaLocation)));

            schemas.Compile(null, true);

            var xmlSchemaImporter = new XmlSchemaImporter(schemas);

            var codeNamespace = new CodeNamespace("Hosca.FpML4_2");
            var xmlCodeExporter = new XmlCodeExporter(codeNamespace);

            var xmlTypeMappings = new List<XmlTypeMapping>();

            foreach (XmlSchemaType schemaType in rootSchema.SchemaTypes.Values)
                xmlTypeMappings.Add(xmlSchemaImporter.ImportSchemaType(schemaType.QualifiedName));
            foreach (XmlSchemaElement schemaElement in rootSchema.Elements.Values)
                xmlTypeMappings.Add(xmlSchemaImporter.ImportTypeMapping(schemaElement.QualifiedName));

            xmlTypeMappings.ForEach(xmlCodeExporter.ExportTypeMapping);

            CodeGenerator.ValidateIdentifiers(codeNamespace);

            foreach (CodeTypeDeclaration codeTypeDeclaration in codeNamespace.Types)
            {
                for (int i = codeTypeDeclaration.CustomAttributes.Count - 1; i >= 0; i--)
                {
                    CodeAttributeDeclaration cad = codeTypeDeclaration.CustomAttributes[i];
                    if (cad.Name == "System.CodeDom.Compiler.GeneratedCodeAttribute")
                        codeTypeDeclaration.CustomAttributes.RemoveAt(i);
                }
            }

            using (var writer = new StringWriter())
            {
                new CSharpCodeProvider().GenerateCodeFromNamespace(codeNamespace, writer, new CodeGeneratorOptions());

                //Console.WriteLine(writer.GetStringBuilder().ToString());

                File.WriteAllText(Path.Combine(rootFolder, "FpML4_2.Generated.cs"), writer.GetStringBuilder().ToString());
            }

            Console.ReadLine();
        }

        private static XmlSchema GetSchemaFromFile(string fileName)
        {
            using (var fs = new FileStream(Path.Combine(rootFolder, fileName), FileMode.Open))
                return XmlSchema.Read(fs, null);
        }

        private static void ExtractIncludes(XmlSchema xmlSchema, ref List<XmlSchemaExternal> schemaList)
        {
            foreach (XmlSchemaExternal include in xmlSchema.Includes)
            {
                if (!schemaList.Select(s => s.SchemaLocation).Contains(include.SchemaLocation))
                    schemaList.Add(include);

                if (include.Schema == null)
                {
                    XmlSchema schema = GetSchemaFromFile(include.SchemaLocation);

                    ExtractIncludes(schema, ref schemaList);
                }
                else
                    ExtractIncludes(include.Schema, ref schemaList);
            }
        }
    }
}