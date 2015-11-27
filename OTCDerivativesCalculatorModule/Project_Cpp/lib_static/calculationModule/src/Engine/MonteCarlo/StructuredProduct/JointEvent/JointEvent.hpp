#ifndef calculationModule_jointevent_hpp
#define calculationModule_jointevent_hpp

#include <vector>
#include <ql/errors.hpp>
#include <ql/types.hpp>
#include <valarray>
// bit연산으로 변경

namespace QuantLib {
	//template 로 갈거임.
	class JointEvent {
	  public:
		  JointEvent(bool tf) 
		  { 
			  setbools_.resize(1);
			  setbools_[0] = tf;  
		  }
		  JointEvent(std::valarray<bool> setbools) : setbools_(setbools) 
		  {
			  setboolNum_ = setbools.size();
			  setboolCount_ = setbools.size();
		  }
		  ~JointEvent(){}
		  //usual

		  virtual bool checkJoint(const std::valarray<bool>& checkbools) = 0;

		  virtual bool checkJoint(bool first, bool second) = 0;

		  virtual int getCount() const = 0;

		  virtual int jointSize() {return setboolCount_; }
	  protected:
		  std::valarray<bool> setbools_;
		  bool tf_;
		  int setboolCount_; //계산용 count
		  int setboolNum_; // valarray.size()
	};

	class IdentityJointEvent : public JointEvent {
		public:
			IdentityJointEvent(bool tf) :  JointEvent(tf) {}
			IdentityJointEvent(std::valarray<bool> setbools) //항상 true를 반환할지 false를 반환할지 여부
				: JointEvent(setbools[0]) { } 

			bool checkJoint(const std::valarray<bool>& checkbools) {
				return setbools_[0];
			}
			
			bool checkJoint(bool first, bool second) {
				return setbools_[0];
			}

			int getCount() const{
				return 1;
			}
	
	};
	class SingleEvent : public JointEvent {
		public:
			SingleEvent(bool tf) :  JointEvent(tf) {}
			SingleEvent(std::valarray<bool> setbools) //항상 true를 반환할지 false를 반환할지 여부
				: JointEvent(setbools[0]) { } 

			bool checkJoint(const std::valarray<bool>& checkbools)
			{
				QL_REQUIRE(checkbools.size() > 0 , "size ofcheckbools must positive" << checkbools.size());
				this->checkJoint(checkbools[0]);
				if(checkbools[0] == setbools_[0]){return true;}
				else{return false;}
			}

			bool checkJoint(bool first, bool second) {
				QL_FAIL("not implemented");
			}

			bool checkJoint(bool checkbools) {
				if(checkbools == setbools_[0]){return true;}
				else{return false;}
			}

			int getCount() const{
				QL_FAIL("not implemented");
				return 1;
			}
	
	};

	class AndJointEvent : public JointEvent {
		public:
			AndJointEvent(bool tf) :  JointEvent(tf) {}
			AndJointEvent(std::valarray<bool> setbools) 
				: JointEvent(setbools) { } 

			bool checkJoint(const std::valarray<bool>& checkbools) {
				
				//std::valarray<bool> checkTFs;

				bool checkTF = true;

				QL_REQUIRE(setboolNum_ == checkbools.size(), "setbools size must be same checkbools size ");

				for(Size i=0 ; i < setbools_.size() ; ++i)
				{
					if(setbools_[i] != checkbools[i]){
						checkTF = false;
						break;
					}
				}

				return checkTF;
			}

			bool checkJoint(bool first, bool second)
			{
				QL_REQUIRE(setboolNum_ == 2, "setbools size must be 2");

				if(setbools_[0] == first && setbools_[1] == second)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			int getCount() const{
				QL_FAIL("not implemented");
				return 1;
			}
	
	};

	class ORJointEvent : public JointEvent {
		public:
			ORJointEvent(bool tf) :  JointEvent(tf) {}
			ORJointEvent(std::valarray<bool> setbools) 
				: JointEvent(setbools) { } 

			bool checkJoint(const std::valarray<bool>& checkbools) {

				//std::valarray<bool> checkTFs;

				bool checkTF = false;

				QL_REQUIRE(setbools_.size() == checkbools.size(), "setbools size must be same checkbools size ");

				for(Size i=0 ; i < setbools_.size() ; ++i)
				{
					if(setbools_[i] == checkbools[i]){
						checkTF = true;
						break;
					}
				}


				return checkTF;
			}

			bool checkJoint(bool first, bool second)
			{
				QL_REQUIRE(setboolNum_ == 2, "setbools size must be 2");

				if(setbools_[0] == first || setbools_[1] == second)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			int getCount() const{
				QL_FAIL("not implemented");
				return 1;
			}
	
	};

	class CompJointEvent : public JointEvent {
		public:
			CompJointEvent(bool tf) :  JointEvent(tf) {}
			CompJointEvent(std::valarray<bool> setbools) //항상 true를 반환할지 false를 반환할지 여부
				: JointEvent(setbools) { } 

			bool checkJoint(const std::valarray<bool>& checkbools) {
				QL_FAIL("not implemented");
				return setbools_[0];
			}

			bool checkJoint(bool first, bool second)
			{
				QL_FAIL("not implemented");

				return true;

			}

			int getCount() const{
				QL_FAIL("not implemented");
				return 1;
			}
	
	};

	//class JointTimeEvent : public JointEvent {
	class JointTimeEvent : public JointEvent {
		public:
			JointTimeEvent(Size setCount) :  JointEvent(true), setCount_(setCount) {}

			inline void addTF()
			{
				count_ += count_;
			}
			inline bool eventOcc()
			{
				if(count_ > setCount_){return tf_;}
				else{return false;}
			}
			inline void reset(){count_ = 0;}

			bool checkJoint(bool first, bool second)
			{
				// 아직 미구현.
				return true;
			}
			bool checkJoint(const std::valarray<bool>& checkbools) {
				return setbools_[0];
			}
			bool checkJoint(const std::valarray<bool>& checkbools,int startDatePosition,int refDatePosition) {
				return setbools_[0];
			}
			int getCount() const{
				return count_;
			}
		private:
			int setCount_;
			int count_;
	
	};



	class AtLeatJointEvent : public JointEvent {
		public:
			AtLeatJointEvent(bool tf) : JointEvent(tf) 
			{
				numSetAtLeast_=1;
				setboolCount_=1;
			}
			AtLeatJointEvent(std::valarray<bool> setbools,
							 int numSetAtLeast = 1) 
				: JointEvent(setbools) 
			{
				numSetAtLeast_=numSetAtLeast;
			} 
			int getCount(){return leastCount_;}

			bool checkJoint(const std::valarray<bool>& checkbools) {
			
				//QL_REQUIRE(setboolCount_==checkbools.int(),"input int and check int is not same")
				int leastCount = 0;
				
				for(int i=0;i<setboolCount_;++i){
					if(checkbools[i] == setbools_[i]){
						leastCount += 1;	
					}
				}

				leastCount_ = leastCount;
				if(leastCount_ >= numSetAtLeast_){tf_=true;}
				else{tf_=false;}
					
				return tf_;

			}
		
			//bool checkJoint(const std::valarray<bool>& checkbools,int startDatePosition,int refDatePosition){
			//	
			//	//QL_REQUIRE(setboolCount_==checkbools.int(),"input int and check int is not same")
			//	int leastCount = 0;
			//	
			//	for(int i=0;i<refDatePosition;++i){
			//		if(setbools_[i] == setbools_[i]){
			//			leastCount += 1;	
			//		}
			//	}

			//	leastCount_ = leastCount;
			//	if(leastCount_ >= numSetAtLeast_){tf_=true;}
			//	else{tf_=false;}
			//		
			//	return tf_;

			//}

			private:
				int numSetAtLeast_;
				int leastCount_; 
				bool tf_;;
	
	};

}

#endif