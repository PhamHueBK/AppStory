using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.rule
{
    
 class Program1
    {
        public static void Main()
        {
            string x = "gioa";
            Rule[] allRules = new[]
            {
               new Rule(), new Rule1(),new Rule2(),new Rule3(),new Rule4(),new Rule5(),new Rule6(), new Rule7(),new Rule8(),new Rule9()
               ,new Rule10(),new Rule11(),new Rule12(),new Rule13()
            };
            for (int j = 0; j < allRules.Length; j++)
            {
                if (!allRules[j].IsValid(x))
                {
                    allRules[j].explain();
                    return;
                }
            }
        }
    }
    class Rule
    {
        public virtual bool IsValid(string x)
        {
            return true;
        }
        public virtual void explain()
        {
            Console.WriteLine(" base error ");
        }
    }
    class Rule1 : Rule
    {
        string consonant = "bcdđghklmnpqrstvx";
        string vowel = "aăâeêioôơuưy";
        public override bool IsValid(string x)
        {
            if (x.Length > 7)
            {
                return false;
            }
            else
            {
                return base.IsValid(x);
            }
        }
        public override void explain()
        {
            Console.WriteLine(" too 7 character ");

        }
    }
    class Rule2 : Rule
    {
        string consonant = "bcdđghklmnpqrstvx";
        string vowel = "aăâeêioôơuưy";
        public override bool IsValid(string x)
        {

            bool flag = true;
            string wrongChars = "wjzf";
            for (int i = 0; i < x.Length; i++)
            {
                if (wrongChars.Contains(" " + x[i]))
                {
                    flag = false;
                }
            }
            return flag;
        }

        public override void explain()
        {
            Console.WriteLine(" Contains special characters");
        }
    }
    class Rule3 : Rule
    {
        string consonant = "bcdđghklmnpqrstvx";
        string vowel = "aăâeêioôơuưy";
        public override bool IsValid(string x)
        {
            bool flag = true;


            if (consonant.Contains(" " + x[x.Length - 1]))
            {
                flag = false;
            }

            return flag;
        }
        public override void explain()
        {
            Console.WriteLine("rule 3");
        }
    }
    class Rule4 : Rule
    {
        string consonant = "bcdđghklmnpqrstvx";
        string vowel = "aăâeêioôơuưy";
        public override bool IsValid(string x)
        {
            bool flag = true;
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (consonant.Contains(" " + x[i]) == true)
                {
                    count++;
                }
            }
            if (count > 5) flag = false;


            return flag;
        }
        public override void explain()
        {
            Console.WriteLine(" rule 4");
        }
    }
    class Rule5 : Rule
    {
        string consonant = "bcdđghklmnpqrstvx";
        string vowel = "aăâeêioôơuưy";
        public override bool IsValid(string x)
        {
            bool flag = true;
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (vowel.Contains(" " + x[i]) == true)
                {
                    count++;
                }
            }
            if (count > 3) flag = false;


            return flag;
        }
        public override void explain()
        {
            Console.WriteLine(" Rule 5");
        }
    }
    class Rule6 : Rule
    {
        public override bool IsValid(string x)
        {
            string words = "ieyê";
            char[] key = x.ToCharArray();
            if ((key[0] == 'C') && (words.Contains("" + key[1])))
            {
                return false;
            }
            else return true;

        }
        public override void explain()
        {
            Console.WriteLine(" Rule 6");
        }


    }
    class Rule7 : Rule
    {
        public override bool IsValid(string x)
        {
            string words = "aăâoôơuuôưươ";
            char[] key = x.ToCharArray();
            if ((key[0] == 'k') && (words.Contains("" + key[1])))
            {
                return false;
            }
            else return true;

        }
        public override void explain()
        {
            Console.WriteLine(" Rule 7");
        }


    }
    class Rule8 : Rule
    {
        public override bool IsValid(string x)
        {
            //string words = "ieê";
            string words = "aăâoôơuuôưươ";
            char[] key = x.ToCharArray();
            if (((key[0] == 'g') && (key[1] == 'h')) && (words.Contains("" + key[2])))
            {
                return false;
            }
            else return true;
            if (((key[0] == 'n') && (key[1] == 'g') && (key[2] == 'h')) && (words.Contains("" + key[3])))
            {
                return false;
            }
            else return true;

        }
        public override void explain()
        {
            Console.WriteLine(" Rule 8");
        }


    }
    class Rule9 : Rule
    {
        public override bool IsValid(string x)
        {
            string words = "ieê";
            //string words = "aăâoôơuuôưươ";
            char[] key = x.ToCharArray();
            if (((key[0] == 'n') && (key[1] == 'g')) && (words.Contains("" + key[2])))
            {
                return false;
            }
            else return true;
            if ((key[0] == 'g') && (words.Contains("" + key[1])))
            {
                return false;
            }
            else return true;


        }
        public override void explain()
        {
            Console.WriteLine(" Rule 9");
        }


    }
    class Rule10 : Rule
    {
        public override bool IsValid(string x)
        {
            string[] words = { "oa", "oe", "uâ", "uy" };
            char[] key = x.ToCharArray();
            string phu = key[1].ToString() + key[2].ToString();
            if ((key[0] == 'n') && ((words[0] == phu) || (words[1] == phu) || (words[2] == phu) || (words[3] == phu)))
            {
                return false;
            }
            else
                return true;

        }
        public override void explain()
        {
            Console.WriteLine(" Rule 10");
        }


    }
    class Rule11 : Rule
    {
        public override bool IsValid(string x)
        {
            string[] words = { "oa", "oă", "oe", "uê", "uâ" };
            string[] exception = { "soát", "soạt", "soạng", "soạn", "suất" };
            char[] key = x.ToCharArray();
            string phu = key[1].ToString() + key[2].ToString();
            if ((key[0] == 's') && ((words[0] == phu) || (words[1] == phu) || (words[2] == phu) || (words[3] == phu) || (words[4] == phu)))
            {
                for (int i = 0; i < exception.Length; i++)
                {
                    if (x == exception[i]) return true;
                }
                return false;
            }
            else
                return true;

        }
        public override void explain()
        {
            Console.WriteLine(" Rule 11");
        }


    }

    class Rule13 : Rule
    {
        public override bool IsValid(string x)
        {
            string[] words = { "oa", "oă", "oe", "uê", "uy" };
            char[] key = x.ToCharArray();
            string phu1 = key[2].ToString() + key[3].ToString();

            if ((key[0] == 'g') && (key[1] == 'i') && ((words[0] == phu1) || (words[1] == phu1) || (words[2] == phu1) || (words[3] == phu1) || (words[4] == phu1)))
            {
                return false;
            }
            else
                return true;

        }
        public override void explain()
        {
            Console.WriteLine(" Rule 13");
        }


    }
    class Rule12 : Rule
    {
        public override bool IsValid(string x)
        {
            string[] words = { "oa", "oă", "oe", "uê", "uy" };
            char[] key = x.ToCharArray();
            string phu = key[1].ToString() + key[2].ToString();
            if ((key[0] == 'r') && ((words[0] == phu) || (words[1] == phu) || (words[2] == phu) || (words[3] == phu) || (words[4] == phu)))
            {
                return false;
            }
            else
                return true;


        }
        public override void explain()
        {
            Console.WriteLine(" Rule 12");
        }


    }

}
