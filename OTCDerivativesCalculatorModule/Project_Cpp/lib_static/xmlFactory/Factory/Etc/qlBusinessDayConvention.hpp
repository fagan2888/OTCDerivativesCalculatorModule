#ifndef xmlFactory_qlbusinessdayconventionfactory_hpp
#define xmlFactory_qlbusinessdayconventionfactory_hpp

#include <ql/time/businessdayconvention.hpp>
#include <boost/algorithm/string.hpp>

namespace XmlFactory {
		
	class qlBusinessDayConvention {

		public:
			qlBusinessDayConvention()
			{
			
			}

			QuantLib::BusinessDayConvention businessDayConvention(const std::string& typeStr)
			{
				QuantLib::BusinessDayConvention bdc;

				std::string upperStr = boost::to_upper_copy(typeStr);

				if(upperStr=="FOLLOWING")
				{
					bdc = QuantLib::Following;
				}
				else
				{
					QL_FAIL("unknown type calendar string");
				}

				return bdc;

			}

		
	};

}
#endif