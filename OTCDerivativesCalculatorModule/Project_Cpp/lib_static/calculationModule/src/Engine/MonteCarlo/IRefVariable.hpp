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

			// ------------------------- ����� ������ ���� ------------------------
			// ����� input
			//std::vector<VariableInfo> usingVariableInfoList_;

			// ����� input �� ���� flag , ���δ� ���� ����Ҽ� ��� ����
			std::vector<bool> usedVarFlagList_;

			//���� Ŭ�������� ���ǵ� ���� ( ex. EventOccDate , minValue )
			std::vector<std::string> definedVarNameList_;

			// ��ϵ� ��ġ�� , �̰� ����ϸ� global �Ǵ� ���ڰ� ����� pathGenFactory�� ������ �־�� �ϹǷ�
			// �켱 ���߿� ��� ( debug�Ҷ��� ������ ) �ӵ� ���� �׳� pass��
			//std::vector<Size> definedVarPositions_;
			
			// ��ϵ� �������� ( ��ġ�� �����ͳ� ���� �ϳ��� ����� ���� )
			std::valarray<boost::shared_ptr<variableStore>> valueTypeRefPosition_;

			//-------------------------------------------------------------------
			std::valarray<Size> fixingDatePositions_;

			std::vector<boost::shared_ptr<VariableInfo>> usingVariableInfoList_;

	};

}

#endif