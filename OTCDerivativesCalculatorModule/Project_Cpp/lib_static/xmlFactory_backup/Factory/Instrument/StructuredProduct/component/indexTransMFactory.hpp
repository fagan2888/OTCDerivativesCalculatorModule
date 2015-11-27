#pragma once

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <xmlFactory/util/convertFunction.hpp>
#include <ql/testClass/StandardSwap/IndexTransManager.hpp>


using namespace QuantLib;

namespace XmlFactory {

class IndexTransMFactory {

	//typedef typename std::vector<std::pair<std::string,boost::shared_ptr<IndexTransManager>>> itms_type;

	public:
		IndexTransMFactory(){}
		//std::vector<boost::shared_ptr<IndexTransManager>> getIndexTransMs(TiXmlNode* xmlNode,Date payoffDates);

		boost::shared_ptr<IndexTransBase> getIndexTran(TiXmlNode* xmlNode);


};

}