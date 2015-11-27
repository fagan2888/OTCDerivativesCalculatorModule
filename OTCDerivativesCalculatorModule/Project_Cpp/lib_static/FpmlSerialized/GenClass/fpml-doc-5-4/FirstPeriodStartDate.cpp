// FirstPeriodStartDate.cpp 
#include "FirstPeriodStartDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FirstPeriodStartDate::FirstPeriodStartDate(TiXmlNode* xmlNode)
: XsdTypeDate(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
}

