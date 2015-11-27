#ifndef xmlFactory_nullFactory_hpp
#define xmlFactory_nullFactory_hpp

#include <Factory/instrumentFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class NullFactory : public InstrumentFactory 
	{
		public:
			NullFactory() { }
			
			void calculate(const std::string& instInfoStr,
						   const std::string& paraInfoStr) { }

	};
}

#endif