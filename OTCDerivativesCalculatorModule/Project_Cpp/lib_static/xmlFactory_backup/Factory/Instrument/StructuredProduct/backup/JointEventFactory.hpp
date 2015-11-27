#ifndef xmlFactory_jointEvent_Factory_hpp
#define xmlFactory_jointEvent_Factory_hpp

#include <standardSwap\Factory\IFactory.hpp>
#include <standardSwap/xmlUtilHeader.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/JointEvent/JointEvent.hpp>

using namespace QuantLib;

namespace XmlFactory {
	
	class JointEventFactory : public IFactory{
		public:
			JointEventFactory();
			JointEventFactory(TiXmlNode* xmlNode);
	
			boost::shared_ptr<JointEvent> getJointEvent(){return jointEvent_;}

			void build();
			void parseXml(TiXmlNode* xmlNode);

		protected:
			boost::shared_ptr<JointEvent> jointEvent_;
	};

}

#endif