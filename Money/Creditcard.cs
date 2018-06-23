using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public enum CardType
    {
        Unknown = 0,
        MasterCard = 1,
        VISA = 2,
        Amex = 3,
        Discover = 4,
        DinersClub = 5,
        JCB = 6,
        enRoute = 7,
        Savings,
    }

    // Class to hold credit card type information
    public class CardTypeInfo
    {
        public CardTypeInfo(string regEx, int length, CardType type)
        {
            RegEx = regEx;
            Length = length;
            Type = type;
        }

        public string RegEx { get; set; }
        public int Length { get; set; }
        public CardType Type { get; set; }
    }
    
    public class Creditcard
    {

        public static string MaskDigits(string input)
        {
            //take first 6 characters
            string firstPart = input.Substring(0, 4);

            //take last 4 characters
            int len = input.Length;
            string lastPart = input.Substring(len - 4, 4);

            return firstPart + " **** **** " + lastPart;
        }
    }
}
