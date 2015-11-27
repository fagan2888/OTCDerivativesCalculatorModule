// IdentifiedPayerReceiver.cpp 
#include "IdentifiedPayerReceiver.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IdentifiedPayerReceiver::IdentifiedPayerReceiver(TiXmlNode* xmlNode)
: PayerReceiverEnum(xmlNode)
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

