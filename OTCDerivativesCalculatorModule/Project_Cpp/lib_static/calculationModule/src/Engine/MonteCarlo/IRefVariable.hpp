#ifndef quantlib_refVariable_hpp
#define quantlib_refVariable_hpp

#include <vector>
#include <valarray>
#include <ql/types.hpp>
#include <string>
#include <boost/shared_ptr.hpp>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/variableInfo/variableInfo.hpp>
#include <ql/indexes/indexmanager.hpp>
#include <src/util/DateHelper.hpp>

namespace QuantLib {

	class IRefVariable 
	{
		public:

			virtual ~IRefVariable() { }

			IRefVariable(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void setRefVariable(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			virtual void linkVariablePtr(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) { }

			// ------------------------- 사용할 변수를 위함 ------------------------
			// 사용할 input
			//std::vector<VariableInfo> usingVariableInfoList_;

			// 사용할 input 에 대한 flag , 전부다 값을 등록할수 없어서 만듬
			std::vector<bool> usedVarFlagList_;

			//하위 클래스에서 정의될 것임 ( ex. EventOccDate , minValue )
			std::vector<std::string> definedVarNameList_;

			// 등록된 위치임 , 이걸 사용하면 global 또는 각자가 멤버로 pathGenFactory를 가지고 있어야 하므로
			// 우선 나중에 고려 ( debug할때는 좋을듯 ) 속도 때매 그냥 pass됨
			//std::vector<Size> definedVarPositions_;
			
			// 등록된 포인터임 ( 위치나 포인터나 둘중 하나를 사용할 것임 )
			std::valarray<boost::shared_ptr<variableStore>> valueTypeRefPosition_;

			//-------------------------------------------------------------------
			std::valarray<Size> fixingDatePositions_;

			std::vector<boost::shared_ptr<VariableInfo>> usingVariableInfoList_;

	};

}

#endif