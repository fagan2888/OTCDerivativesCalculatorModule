#include <ql/testClass/standardswapTest/nullpayoffmanager.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

NullPayoffManager::NullPayoffManager()
		: PayoffManager(Date(),"",std::vector<std::pair<std::string,boost::shared_ptr<IndexTransManager>>>())
{
	int a = 0;
}

}