using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPDevNH_CSharp7
{
    class PatternMatching : Example
    {
        public static int DiceSum2(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                if (item is int val)  //lots going on here.    int val = item (if item is int)
                    sum += val;
                else if (item is IEnumerable<object> subList)  //similar cast and assignment
                    sum += DiceSum2(subList);
            }
            return sum;
        }


        //even more fun when used with a switch statement
        public static int DiceSum3(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    case int val:
                        sum += val;
                        break;
                    case IEnumerable<object> subList:
                        sum += DiceSum3(subList);
                        break;
                }
            }
            return sum;
        }

        public static int DiceSum5(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    case 0:    //clasic value check
                        break;
                    case int val:  // new conditional cast assignment
                        sum += val;
                        break;
                    case PercentileDie die:  //specific custom class
                        sum += die.Multiplier * die.Value;
                        break;
                    case IEnumerable<object> subList when subList.Any():
                        sum += DiceSum5(subList);
                        break;
                    case IEnumerable<object> subList:
                        break;
                    case null:
                        break;
                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }
            return sum;
        }

        public struct PercentileDie
        {
            public int Value { get; }
            public int Multiplier { get; }

            public PercentileDie(int multiplier, int value)
            {
                this.Value = value;
                this.Multiplier = multiplier;
            }
        }
    }
}
