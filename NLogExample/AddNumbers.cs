using System;
using System.Collections.Generic;
using System.Text;

namespace NLogExample
{
    class AddNumbers
    {
        //Object
        private readonly NLog nLog = new NLog();
        
        //Function to Add Numbers
        public int Sum(int fistNumber, int secondNumber)
        {
            if (fistNumber==0 || secondNumber==0)
            {
                nLog.LogDebug("Debug SuccessFull : Sum()");
                nLog.LogError("Input numbers Can Not be Zero");
                nLog.LogWarn("a or b should not equal to 0");
            }

            //Adition
            int result = fistNumber + secondNumber;
            nLog.LogDebug("Debug SuccessFull : Sum()");
            nLog.LogInfo("Sum Method Passed, Result : "+result);
            return result;
            
        }        

    }
}
