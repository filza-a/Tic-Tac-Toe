using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class classTicTacToe
    {


        bool toggleValue = true;
        String userOne = "O";
        String userTwo = "X";

        //setter toggleValue
        public void setToggleValue(bool toggleValue)
        {
            this.toggleValue = toggleValue;
        }

        //getter toggleValue
        public bool getToggleValue()
        {
            return toggleValue;
        }

        //getter userOne
        public String getUserOne()
        {
            return userOne;
        }

        //getter userTwo
        public String getUserTwo()
        {
            return userTwo;
        }
    }
}
