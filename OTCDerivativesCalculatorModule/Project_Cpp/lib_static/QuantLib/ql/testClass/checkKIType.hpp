#ifndef quantlib_checkKIType_hpp
#define quantlib_checkKIType_hpp

#include <ql/qldefines.hpp>
#include <ostream>

namespace QuantLib {

    enum CheckKIType { ContiKI , DailyKI , MonthlyKI };

    std::ostream& operator<<(std::ostream&,
                             CheckKIType);

}

#endif