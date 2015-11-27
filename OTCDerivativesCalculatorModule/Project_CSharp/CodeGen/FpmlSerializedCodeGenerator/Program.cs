using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpCodeGen;
using TestConsole;

namespace FpmlSerializedCodeGenerator
{

    class Program
    {
        static void Main(string[] args)
        {
            string solutionPath = @"D:\Project File\OTCDerivativesCalculatorModule\";

            string xsdFolder = solutionPath + @"Project_CSharp\CodeGen\FpmlSerializedCodeGenerator\XSD_File\";
            //string rootFolder = @"D:\Project File\OTCDerivativesCalculatorModule\Project_CSharp\RiskMonitor\Model\GeneratedClass\";
            //string rootViewModelFolder = @"D:\Project File\OTCDerivativesCalculatorModule\Project_CSharp\RiskMonitor\Model\GeneratedClass\ViewModel";

            string rootFolder = @"D:\Project File\OTCDerivativesCalculatorModule\Excel_Interface2\GeneratedClass\";
            string rootViewModelFolder = @"D:\Project File\OTCDerivativesCalculatorModule\Excel_Interface2\GeneratedClass\ViewModel";

            string relFolder = @"GeneratedCode\";

            CSharpGenerator genCSharp = new CSharpGenerator(xsdFolder, rootFolder, relFolder,false);
            genCSharp.generate();

            CSharpGenerator genViewModeCSharp = new CSharpGenerator(xsdFolder, rootViewModelFolder, relFolder, true);
            genViewModeCSharp.generate();


            //----------------------------

           rootFolder = @"D:\Project File\OTCDerivativesCalculatorModule\Project_Cpp\lib_static\xmlFactory\GenClass\";
            relFolder = @"GenClass\";
            //xsdFolder = @"D:\Project\2010\Project C++\OTCDerivativesCalculatorModule\FpmlSerialized\XSD\confirmation\";

            string filterString = "";

            Console.Write("filter string input : ");
            //filterString = Console.ReadLine();

            CppGenerator genCpp = new CppGenerator(xsdFolder, rootFolder, relFolder);

            genCpp.filterStr_ = filterString;

            genCpp.generate();


        }
    }
}
