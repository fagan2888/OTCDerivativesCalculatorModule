#ifndef xmlFactory_interestrateindexfactory_hpp
#define xmlFactory_interestrateindexfactory_hpp

#include <ql/indexes/ibor/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlInterestRateIndexFactory {
		public:
			enum irType 
			{
				KorCD = 0
			
			};

			qlInterestRateIndexFactory()
			{
			
			}

			boost::shared_ptr<QuantLib::InterestRateIndex> irIndex(irType it,
																   Integer n,
																   TimeUnit units)
			{
				QuantLib::Period period = QuantLib::Period(n,units);
				switch (it) 
				{
					case KorCD :
						return boost::shared_ptr<InterestRateIndex>(new Euribor(period));
						break;
					default:
						break;
				}
			}
	};

}
#endif