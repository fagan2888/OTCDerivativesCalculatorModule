#include <xmlFactory/Factory/Instrument/StructuredProduct/JointEventFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {
	
	JointEventFactory::JointEventFactory(TiXmlNode* xmlNode)
	{
		this->parseXml(xmlNode);
	}

	void JointEventFactory::parseXml(TiXmlNode* xmlNode)
	{
		std::vector<bool> setbools;

		//TiXmlNode* tfNode = xmlNode->FirstChild("truefalse");

		std::vector<std::string> tfs = ConvertFunction::getElementValues(xmlNode,"truefalse"); 

		for (Size i=0 ;i<tfs.size(); ++i){
			if(tfs[i]=="True"){
				setbools.push_back(true);
			}else{setbools.push_back(false);}
		}


		if(setbools.size()<1){setbools.push_back(true);}

		jointEvent_ = boost::shared_ptr<JointEvent>(new IdentityJointEvent(setbools));
	
	}

	void JointEventFactory::build()
	{
	
	}
}
