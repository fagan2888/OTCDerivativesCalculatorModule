#ifndef calculationModule_SubEvents_hpp
#define calculationModule_SubEvents_hpp

//#include <string>
#include <boost/shared_ptr.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventCheck/IEventCheck.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/JointEvent/JointEvent.hpp>


namespace QuantLib {

	//이놈을 xml 에서 href 로 받으면 순환포함파일 때매 빌드가 안됨. 그래서 id 형태로 안가고 그냥 symbol 형태로 감.

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
