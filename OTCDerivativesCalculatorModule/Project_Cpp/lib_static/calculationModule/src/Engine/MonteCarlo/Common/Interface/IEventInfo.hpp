#ifndef quantlib_mc_ieventinfo_hpp
#define quantlib_mc_ieventinfo_hpp

namespace QuantLib {
	class IEventInfo {
		public:
			virtual void initialize(const TimeGrid& timeGrid) = 0; 
			virtual void eventOcc(const MultiPath& multiPath) = 0;
			virtual Size eventDateLocation() = 0;
	};

}

#endif