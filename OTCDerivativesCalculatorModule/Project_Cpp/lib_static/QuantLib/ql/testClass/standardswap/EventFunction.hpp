#ifndef quantlib_eventfunction_hpp
#define quantlib_eventfunction_hpp

namespace QuantLib {
	//template 로 갈거임.
	class EventFunction {
	  public:
		  ~EventFunction(){}
		virtual bool checkEventOcc(double) const = 0;

	};

	class IdentityEventCheck : public EventFunction {
		public:
		IdentityEventCheck(bool identity=true) //항상 true를 반환할지 false를 반환할지 여부
			: identity_(identity){} //eqality 나중에?

		bool checkEventOcc(double value) const{
			return identity_;
		}
		private:
			bool identity_;
	
	};

	class UpEventCheck  : public EventFunction {
	  public:
		UpEventCheck(double checkValue , bool equality)
			: checkValue_(checkValue){} //eqality 나중에?

		bool checkEventOcc(double value) const{
			if(value > checkValue_){return true;}
			else{return false;}
		}
	  private:
		double checkValue_;

	};
	
	class DownEventCheck  : public EventFunction {
	  public:
		DownEventCheck(double checkValue , bool equality)
			: checkValue_(checkValue){}//eqality 나중에?

		bool checkEventOcc(double value) const{
			if(value < checkValue_){return true;}
			else{return false;}
		}
	  private:
		double checkValue_;
	};

	class UpDownEventCheck  : public EventFunction { // a > x  OR  b < x
	  public:
		UpDownEventCheck(double upCheckValue , 
						bool upEquality,
						double downCheckValue , 
						bool downEquality)
			:upCheckValue_(upCheckValue),upEquality_(upEquality),
			 downCheckValue_(downCheckValue),downEquality_(downEquality) {}	//eqality 나중에?

		bool checkEventOcc(double value) const{
			if(value < downCheckValue_ || value > upCheckValue_){return true;}
			else{return false;}
		}
	  private:
		double upCheckValue_;
		double downCheckValue_;
		bool upEquality_;
		bool downEquality_;
	};

	class RangeCheck  : public EventFunction { // a < x < b
	  public:
		RangeCheck(double upCheckValue , 
						bool upEquality,
						double downCheckValue , 
						bool downEquality)
			:upCheckValue_(upCheckValue),upEquality_(upEquality),
			 downCheckValue_(downCheckValue),downEquality_(downEquality) {}	//eqality 나중에?

		bool checkEventOcc(double value) const{
			if(value < upCheckValue_ && value > downCheckValue_){return true;}
			else{return false;}
		}
	  private:
		double upCheckValue_;
		double downCheckValue_;
		bool upEquality_;
		bool downEquality_;
	};

}

#endif