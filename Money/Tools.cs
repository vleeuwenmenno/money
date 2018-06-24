using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Money
{
    public class Tools
    {
        public static bool ValidateIBAN(string bankAccount)
        {
            try
            {
                bankAccount = bankAccount.ToUpper(); //IN ORDER TO COPE WITH THE REGEX BELOW
                if (String.IsNullOrEmpty(bankAccount))
                    return false;
                else if (System.Text.RegularExpressions.Regex.IsMatch(bankAccount, "^[A-Z0-9]"))
                {
                    bankAccount = bankAccount.Replace(" ", String.Empty);
                    string bank =
                    bankAccount.Substring(4, bankAccount.Length - 4) + bankAccount.Substring(0, 4);
                    int asciiShift = 55;
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in bank)
                    {
                        int v;
                        if (Char.IsLetter(c)) v = c - asciiShift;
                        else v = int.Parse(c.ToString());
                        sb.Append(v);
                    }
                    string checkSumString = sb.ToString();
                    int checksum = int.Parse(checkSumString.Substring(0, 1));
                    for (int i = 1; i < checkSumString.Length; i++)
                    {
                        int v = int.Parse(checkSumString.Substring(i, 1));
                        checksum *= 10;
                        checksum += v;
                        checksum %= 97;
                    }
                    return checksum == 1;
                }
                else
                    return false;
            }
            catch (Exception ex) { return false; }
        }
        public static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        public static decimal ExchangeRate(string currency)
        {
            string url = "http://finance.yahoo.com/webservice/" + "v1/symbols/allcurrencies/quote?format=xml";
            try
            {
                // Load the data.
                XmlDocument doc = new XmlDocument();
                doc.Load(url);

                // Process the resource nodes.
                XmlNode root = doc.DocumentElement;
                string xquery = "descendant::resource[@classname='Quote']";
                foreach (XmlNode node in root.SelectNodes(xquery))
                {
                    const string name_query =
                        "descendant::field[@name='name']";
                    const string price_query =
                        "descendant::field[@name='price']";

                    string name =
                        node.SelectSingleNode(name_query).InnerText;
                    string price =
                        node.SelectSingleNode(price_query).InnerText;
                    decimal inverse = 1m / decimal.Parse(price);

                    if (name == "USD/" + currency)
                        return inverse;
                }
            }
            catch (Exception ex)
            { }

            return 0.0m;
        }

        // Array of CardTypeInfo objects.
        // Used by GetCardType() to identify credit card types.
        private static CardTypeInfo[] _cardTypeInfo = {
            new CardTypeInfo("^(51|52|53|54|55)", 16, CardType.MasterCard),
            new CardTypeInfo("^(4)", 16, CardType.VISA),
            new CardTypeInfo("^(4)", 13, CardType.VISA),
            new CardTypeInfo("^(34|37)", 15, CardType.Amex),
            new CardTypeInfo("^(6011)", 16, CardType.Discover),
            new CardTypeInfo("^(300|301|302|303|304|305|36|38)",
                            14, CardType.DinersClub),
            new CardTypeInfo("^(3)", 16, CardType.JCB),
            new CardTypeInfo("^(2131|1800)", 15, CardType.JCB),
            new CardTypeInfo("^(2014|2149)", 15, CardType.enRoute),
        };

        public static CardType GetCardType(string cardNumber)
        {
            foreach (CardTypeInfo info in _cardTypeInfo)
            {
                if (cardNumber.Length == info.Length &&
                    Regex.IsMatch(cardNumber, info.RegEx))
                    return info.Type;
            }

            return CardType.Unknown;
        }
    }
}
