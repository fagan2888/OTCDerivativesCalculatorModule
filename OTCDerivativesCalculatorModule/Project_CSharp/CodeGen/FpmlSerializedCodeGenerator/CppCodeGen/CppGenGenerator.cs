using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.IO;
using CppCodeGen;

namespace TestConsole
{
    class CppGenerator
    {
        //public const string rootFolder = @"D:\Project\2010\Project C++\OTCDerivativesCalculatorModule\FpmlSerialized\GenClass\";
        //public const string relFolder = @"GenClass\";
        //public const string xsdFolder = @"D:\Project\2010\Project C++\OTCDerivativesCalculatorModule\FpmlSerialized\XSD\confirmation\";


        //public const string rootFolder = @"D:\Project File\OTCDerivativesCalculatorModule\Project_CSharp\XmlBuilder\XmlSerializedClass\";
        //public const string relFolder = @"GenCsharpClass\";
        //public const string xsdFolder = @"D:\Project File\OTCDerivativesCalculatorModule\Xml\XSD\confirmation\";

        public string xsdFolder_ { get; set; }
        public string rootFolder_ { get; set; }
        public string relFolder_ { get; set; }
        public string filterStr_ { get; set; }

        public CppGenerator(string xsdFolder, string rootFolder, string relFolder) 
        {
            this.xsdFolder_ = xsdFolder;
            this.rootFolder_ = rootFolder;
            this.relFolder_ = relFolder;
        }

        private List<string> built_in_type =
                                new List<string>() {"anyURI","base64Binary","boolean","byte","date",
                                                    "dateTime","decimal","double","duration","ENTITIES",
                                                    "ENTITY","float","gDay","gMonth","gMonthDay",
                                                    "gYear","gYearMonth","hexBinary","ID","IDREF",
                                                    "IDREFS","int","integer","language","long",
                                                    "Name","NCName","negativeInteger","NMTOKEN",
                                                    "NMTOKENS","nonNegativeInteger","nonPositiveInteger","normalizedString","NOTATION",
                                                    "positiveInteger","QName","short","string","time",
                                                    "token","unsignedByte","unsignedInt","unsignedLong","unsignedShort"
                                                  
                                                    }; //static 외부
        // Dictionary( name , fileName )
        private Dictionary<string, string> includePath = new Dictionary<string, string>();
        // Dictionary( name , Type ,substitutionGroupType)
        private Dictionary<string, string> elementRef = new Dictionary<string, string>();

        private Dictionary<string, XmlSchemaGroup> elementGroupRef = new Dictionary<string, XmlSchemaGroup>();
        // 중복된 Key값때문에 배열로 감.
        private List<KeyValuePair<string, string>> elementSubstitutionRef = new List<KeyValuePair<string, string>>();

        public void generate()
        {

            string built_in_type_subfoler = "built_in_type";
            Variable.built_in_type = built_in_type;
            ClassGen.built_in_type = built_in_type;

            string subBuiltInPath = System.IO.Path.Combine(rootFolder_, built_in_type_subfoler);
            System.IO.Directory.CreateDirectory(subBuiltInPath);
            foreach (string item in built_in_type)
	        {
                includePath.Add(item, built_in_type_subfoler);
	        }
            
            
            foreach (string item in built_in_type)
            {
                XsdBuiltInVariable xbv = new XsdBuiltInVariable(item);

                using (var writer = new StringWriter())
                {
                    writer.WriteLine(xbv.Code);
                    File.WriteAllText(Path.Combine(subBuiltInPath, xbv.CName + ".hpp"), writer.GetStringBuilder().ToString());
                }
            }

            

            //--------------------------------------------------------
            System.IO.DriveInfo di = new System.IO.DriveInfo(@"D:\");
            Console.WriteLine(di.TotalFreeSpace);
            Console.WriteLine(di.VolumeLabel);

            // Get the root directory and print out some information about it.
            System.IO.DirectoryInfo dirInfo = new DirectoryInfo(xsdFolder_);
            Console.WriteLine(dirInfo.Attributes.ToString());

            System.IO.FileInfo[] fileNames = dirInfo.GetFiles("RiskMonitor-0-1.xsd");

            var rootAllIncludeWriter = new StringWriter();

            foreach (System.IO.FileInfo fi in fileNames)
            {
                RegistEleForRefAttribute(fi.Name);
            }
            foreach (System.IO.FileInfo fi in fileNames)
            {
                Console.WriteLine("{0}: {1}: {2}", fi.Name, fi.LastAccessTime, fi.Length);
                Generation(fi.Name);
                string directoryName = fi.Name.Replace(".xsd","");
                rootAllIncludeWriter.WriteLine("#include <" + relFolder_ +  directoryName + "/all.hpp>");
            }

            File.WriteAllText(Path.Combine(rootFolder_, "all.hpp"), rootAllIncludeWriter.GetStringBuilder().ToString());

        }

        private void Generation(string xsdFileName) 
        {
            string subfoler = xsdFileName.Replace(".xsd","");
            string subBuiltInPath = System.IO.Path.Combine(rootFolder_, subfoler);
            System.IO.Directory.CreateDirectory(subBuiltInPath);

            XmlSchema rootSchema = GetSchemaFromFile(xsdFileName);

            var allIncludeWriter = new StringWriter();
            bool noUseFile = false;

            try
            {
                foreach (XmlSchemaObject item in rootSchema.Items)
                {

                    var hppWriter = new StringWriter();
                    var cppWriter = new StringWriter();

                    string schemaObjectName = "";

                    if (item is XmlSchemaElement)
                    {
                        XmlSchemaElement xe = item as XmlSchemaElement;
                        schemaObjectName = xe.Name + "NoUseFile";
                        noUseFile = true;
                    }
                    else if (item is XmlSchemaComplexType)
                    {
                        

                        XmlSchemaComplexType xsct = item as XmlSchemaComplexType;

                        if (this.filterStr_.Contains(xsct.Name) || this.filterStr_ == "")
                        {

                            //debug
                            Console.WriteLine(xsct.Name);
                            CppCodeGen.Generator gen = new Generator(xsct, elementRef, includePath, elementSubstitutionRef, elementGroupRef);
                            gen.makeCode();
                            hppWriter.WriteLine(gen.HppCode);
                            cppWriter.WriteLine(gen.CppCode);
                            schemaObjectName = xsct.Name;
                        }
                    }
                    else if (item is XmlSchemaSimpleType)
                    {
                        XmlSchemaSimpleType xsst = item as XmlSchemaSimpleType;
                        CppCodeGen.GeneratorSimple gen = new GeneratorSimple(xsst);
                        hppWriter.WriteLine(gen.Code);
                        schemaObjectName = xsst.Name;
                    }

                    if (!noUseFile)
                    {
                        File.WriteAllText(Path.Combine(subBuiltInPath, schemaObjectName + ".hpp"), hppWriter.GetStringBuilder().ToString());
                        File.WriteAllText(Path.Combine(subBuiltInPath, schemaObjectName + ".cpp"), cppWriter.GetStringBuilder().ToString());
                        string includeCode = "#include <" + relFolder_ + subfoler + "\\" + schemaObjectName + ".hpp>";
                        allIncludeWriter.WriteLine(includeCode);
                    }

                }

                File.WriteAllText(Path.Combine(subBuiltInPath, "all.hpp"), allIncludeWriter.GetStringBuilder().ToString());
                //File.WriteAllText(Path.Combine(subBuiltInPath, built_in_type_subfoler + ".hpp"), writer.GetStringBuilder().ToString());
            }
            catch 
            {
                Console.WriteLine("errorOcc -----------------------------------------------------------");
                Console.ReadLine();
            }
        }

        private void RegistEleForRefAttribute(string xsdFileName) 
        {
            XmlSchema rootSchema = GetSchemaFromFile(xsdFileName);
            string subfolerName = xsdFileName.Replace(".xsd", "");

            foreach (XmlSchemaObject item in rootSchema.Items)
            {
                if (item is XmlSchemaSimpleType)
                {
                    XmlSchemaSimpleType xsst = item as XmlSchemaSimpleType;
                    includePath.Add(xsst.Name, subfolerName);

                }else if (item is XmlSchemaComplexType)
                {
                    XmlSchemaComplexType xsct = item as XmlSchemaComplexType;

                    includePath.Add(xsct.Name, subfolerName);
                }else if (item is XmlSchemaElement)
                {
                    XmlSchemaElement xe = item as XmlSchemaElement;
                    if (xe.RefName.IsEmpty)
                    {
                        //string nametype = xe.ElementSchemaType.Name;
                        //string nametype2 = xe.SchemaTypeName.Name;
                        
                        //ref 가 없는 element만 넣어서 나중에 이 List를 뒤져서 Type을 알아냄
                        elementRef.Add(xe.Name, xe.SchemaTypeName.Name);

                        //ref 가 없고 substitutionGroup이 있는 element만 넣어서 나중에 이 List를 뒤져서 substitution 에 추가함
                        if (!xe.SubstitutionGroup.IsEmpty) 
                        {
                            KeyValuePair<string,string> pair = new KeyValuePair<string,string>(xe.SubstitutionGroup.Name,xe.Name);
                            elementSubstitutionRef.Add(pair);
                        }

                    }
                }
                else if (item is XmlSchemaGroup)
                {
                    XmlSchemaGroup xe = item as XmlSchemaGroup;
                    elementGroupRef.Add(xe.Name, xe);
                }
                
            }
        }
        private XmlSchema GetSchemaFromFile(string fileName)
        {
            using (var fs = new FileStream(Path.Combine(xsdFolder_, fileName), FileMode.Open))
                return XmlSchema.Read(fs, null);
        }

    }
}
