using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ahn_OTCBookCOMLibrary
{
    public enum InterpolationEnum
    {
        Linear,
        Spline
    };

    public enum RateTypeEnum
    { 
        Spot,
        Yield

    };

    public enum CalculationEnum
    {
        Max,
        Min,
        Aver

    };

    public enum LossType
    { 
        Worst,
        Best,
        Aver
    };

    public enum InfoType 
    {
        Value,
        Header,
        Header_Value
    };

    public enum CalculateType
    {
        Value,
        ValueAndGreek
    };

    public enum SwapSide 
    {
        Receive,
        Pay
    };

    public enum ResultSide
    {
        Net,
        Pay,
        Receive
    };

    public enum ParameterBuildType
    { 
        Default

    };

    public enum OptionType
    {
        None,
        Callable,
        Puttable

    };


}
