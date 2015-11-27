#pragma once

#include <xmlFactory/util/xmlUtilHeader.hpp>

namespace XmlFactory {

	class IndexMFactory : public IFactory {
		public:
			IndexMFactory();
			IndexMFactory(TiXmlNode* xmlNode);
			
			void parseXml(TiXmlNode* xmlNode);

			boost::shared_ptr<IndexTransManager> getIndexTransM(Date refDates);
			boost::shared_ptr<IndexTransManager> getIndexTransM(std::vector<Date> refDates);
		
			//ITM getIndexTransMTP(TiXmlNode* xmlNode,Date refDates);
			//std::vector<std::string> getBaseIndexSymbol(TiXmlNode* xmlNode);

			void build();

		private:
			boost::shared_ptr<IndexTransBase> selectEachTran(TiXmlNode* xmlNode);

			std::vector<boost::shared_ptr<IndexTransBase>> ITBs_;

			boost::shared_ptr<IndexTransManager> itm_;

	};
	namespace Factory {
		class Return {
			Retrun(TiXmlNode* xmlNode); //내부에서 날짜 ㄱㄱ, dateManager를 통해 관리 할거임.
		};
		class Average {
			Average(TiXmlNode* xmlNode);
		};
		class Basket {
			Basket(TiXmlNode* xmlNode);
		};
	}

}