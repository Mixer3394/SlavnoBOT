using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SlavnoBot
{
    public class Rgx
    {
        public static string regexFunction(string inputText)
        {
            string patternZ = "Ź|Ż|ź|ż";
            string replacementZ = "z";
            string patternE = "Ę|ę";
            string replacementE = "e";
            string patternA = "ą|Ą";
            string replacementA = "a";
            string patternS = "ś|Ś";
            string replacementS = "s";
            string patternC = "ć|Ć";
            string replacementC = "c";
            string patternL = "Ł|ł";
            string replacementL = "l";
            string patternN = "ń|Ń";
            string replacementN = "n";
            string patternO = "ó|Ó";
            string replacementO = "o";
            Regex rgxA = new Regex(patternA);
            Regex rgxC = new Regex(patternC);
            Regex rgxE = new Regex(patternE);
            Regex rgxL = new Regex(patternL);
            Regex rgxN = new Regex(patternN);
            Regex rgxO = new Regex(patternO);
            Regex rgxS = new Regex(patternS);
            Regex rgxZ = new Regex(patternZ);
            string regexInputText = rgxA.Replace(inputText, replacementA);
            regexInputText = rgxC.Replace(regexInputText, replacementC);
            regexInputText = rgxE.Replace(regexInputText, replacementE);
            regexInputText = rgxL.Replace(regexInputText, replacementL);
            regexInputText = rgxN.Replace(regexInputText, replacementN);
            regexInputText = rgxO.Replace(regexInputText, replacementO);
            regexInputText = rgxS.Replace(regexInputText, replacementS);
            regexInputText = rgxZ.Replace(regexInputText, replacementZ);
            return regexInputText;
        }

    }
}
