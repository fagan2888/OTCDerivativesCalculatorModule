#ifndef quantlib_domain_composite_hpp
#define quantlib_domain_composite_hpp

#include "Domain.hpp"


namespace QuantLib {

	class DomainComposite : public Domain {
		public:
			DomainComposite(std::valarray<boost::shared_ptr<Domain>> domains,
							 std::valarray<bool> tf,
							 SetOperation setOper)
					  : domains_(domains), tf_(tf), setOper_(setOper) 
					  {
			
					  }

			bool eventOcc(const std::valarray<Real>& values)
			{
				bool result;

				Size valueNum = values.size();

				std::valarray<bool> tfs(valueNum);

				switch (setOper_) {
					case OR :
						result = false;

						for(Size i = 0 ; i < domains_.size() ; ++i)
						{
							if(tf_[i] == domains_[i]->eventOcc(values))
							{
								result = true;
								break;
							}
						
						}
					case AND :
						result = true;

						for(Size i = 0 ; i < domains_.size() ; ++i)
						{
							if(tf_[i] != domains_[i]->eventOcc(values))
							{
								result = false;
								break;
							}
						}

					default :
						QL_FAIL("unknown setOperation");
				}
						return result;
			
			}

		private:

			std::valarray<boost::shared_ptr<Domain>> domains_;
			std::valarray<bool> tf_;
			SetOperation setOper_;

	};


#endif