#ifndef calculationModule_OverWrapsetter_hpp
#define calculationModule_OverWrapsetter_hpp

namespace QuantLib {
	class OverWrapSetter {
		public:
			OverWrapSetter(const boost::shared_ptr<ContingentEvent> contingentEvent,
						  const boost::shared_ptr<FdmMesher> mesher);

			void OverWrap(array_type& targer, const array_type& OverWrapData)
			{
				
			}


	};

}