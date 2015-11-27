#ifndef xmlFactory_indexTransformationFactory_hpp
#define xmlFactory_indexTransformationFactory_hpp

#include <xmlFactory/Factory/Instrument/StructuredProduct/IFactory.hpp>

namespace XmlFactory {

	class IndexTransformationMFactory : public IFactory {
		public:
			IndexTransformationMFactory();
			
			void parseXml(TiXmlNode* xmlNode);
			void build();
			
			boost::shared_ptr<IndexTransformationManager> getIndexTransfomationM(){return indexTransfomationM_;}

		protected:

			boost::shared_ptr<IndexTransformationManager> indexTransfomationM_;

			
	};


}

#endif
