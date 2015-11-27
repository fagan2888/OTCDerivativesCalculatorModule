#ifndef calculationModule_SubEvents_hpp
#define calculationModule_SubEvents_hpp

//#include <string>
#include <boost/shared_ptr.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventCheck/IEventCheck.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/JointEvent/JointEvent.hpp>


namespace QuantLib {

	//�̳��� xml ���� href �� ������ ��ȯ�������� ���� ���尡 �ȵ�. �׷��� id ���·� �Ȱ��� �׳� symbol ���·� ��.

	//aggregate Class
	class SubEvents {
	  public:
		  
		  SubEvents(bool identity = true);

		  SubEvents(const std::vector<boost::shared_ptr<IEventCheck>>& subEvents,
					const boost::shared_ptr<JointEvent>& joint);

  		  bool eventOcc();
		  Size eventCheckNum();

	  private:

		//std::string symbol_;

		std::vector<IEventCheck*> subEventsPtr_;
		std::vector<boost::shared_ptr<IEventCheck>> subEvents_;
		
		boost::shared_ptr<JointEvent> joint_;
		JointEvent* jointPtr_;
		Size EventCheckNum_;
		  //bool thisEventOcc_;
	};

}

#endif
