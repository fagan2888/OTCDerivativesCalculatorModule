#ifndef calculationModule_indextransmanagerTP_hpp
#define calculationModule_indextransmanagerTP_hpp

#include <src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
#include <ql/methods/montecarlo/multipath.hpp>

namespace QuantLib {
	
	template<class Tran>
	class IndexTransManagerTP : public IndexTransBase {
		public:	
			IndexTransManagerTP(const std::string& symbolName,
								std::vector<Tran> trans)
			: symbolName_(symbolName);
			{
				//
					//TP symbol을 등록하는 코드 필요.
				//

				tranNum_ = transBases.size();
				for(Size i=0;i<tranNum;++i)
				{
					trans_[i] = transBases[i]; 
				}
			}

			template<class Tran>
			inline void calValue()
			{
				for(Size i=0;i<tranNum_;++i)
				{
					trans_[i].calValue();
				}
			}
			
			template<class Tran>
			inline void calValue(int refDatePosition)
			{
				for(Size i=0;i<tranNum_;++i)
				trans_[i].calValue(int refDatePosition);
				//*symbolValuesPtr_ = parser_.Eval();
			}

		private:
			Tran trans_[INDEXMAXNUM];
			Size tranNum_;
	
	};

}

#endif