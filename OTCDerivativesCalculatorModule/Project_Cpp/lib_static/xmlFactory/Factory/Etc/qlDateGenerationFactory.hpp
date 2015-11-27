#ifndef xmlFactory_qldategenerationfactory_hpp
#define xmlFactory_qldategenerationfactory_hpp

#include <string>
#include <ql/errors.hpp>
#include <ql/time/dategenerationrule.hpp>
#include <boost/algorithm/string.hpp>

using namespace QuantLib;

namespace XmlFactory {
	
	class qlDateGenerationFactory {
		public:
			qlDateGenerationFactory()
			{
			
			}

			//QuantLib::DateGeneration::Rule calendar(TiXmlNode* node)
			//{
			//	TiXmlElement* calNode = node->FirstChildElement("calendar");

			//	return this->calendar(calNode->GetText());

			//}

			QuantLib::DateGeneration::Rule dateGeneration(const std::string& typeStr)
			{
				QuantLib::DateGeneration::Rule rule;

				std::string upperStr = boost::to_upper_copy(typeStr);

				if(upperStr=="BACKWARD")
				{
					rule = DateGeneration::Rule::Backward;
				}
				else if(upperStr=="FORWARD")
				{
					rule = DateGeneration::Rule::Forward;
				}
				else if(upperStr=="ZERO")
				{
					rule = DateGeneration::Rule::Zero;
				}
				else if(upperStr=="THIRDWEDNESDAY")
				{
					rule = DateGeneration::Rule::ThirdWednesday;
				}
				else if(upperStr=="TWENTIETH")
				{
					rule = DateGeneration::Rule::Twentieth;
				}
				else if(upperStr=="TWENTIETHIMM")
				{
					rule = DateGeneration::Rule::TwentiethIMM;
				}
				else if(upperStr=="OLDCDS")
				{
					rule = DateGeneration::Rule::OldCDS;
				}
				else if(upperStr=="CDS")
				{
					rule = DateGeneration::Rule::CDS;
				}
				//else if(typeStr==" ¼ýÀÚ ")
				//{
				//	rule = DateGeneration::Rule::Backward;
				//}
				else
				{
					QL_FAIL("unknown type dateGeneration");
				}

				return rule;

			}
	};

}
#endif