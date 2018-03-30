using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        public Queue<string> Search(List<string>paragraps,string keyword)
        {
            Queue<string> result= new Queue<string>();
            string[] temp = keyword.Split(new Char[] { ' ' });
            for(int i = 0; i < temp.Length; i++)
            {
                for(int j = 0; j < paragraps.Count; j++)
                {
                    string[] temp1=paragraps[j].Split(new Char[] { ' ' });
                    for(int k = 0; k < temp1.Length; k++)
                    {
                        if (temp[i] == temp1[k]) i++;
                        if (i == temp.Length)
                        {
                            result.Enqueue(paragraps[j]);
                            break;
                        }
                    }
                }
            }
            return result;

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
                Console.WriteLine(" Contains special characters");
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
                    if (consonant.Contains(x[i]) == true)
                    {
                        count++;
                    }
                }
                if (count > 5) flag = false;


                return flag;
            }
            public override void explain()
            {
                Console.WriteLine(" Contains special characters");
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
                    if (vowel.Contains(x[i]) == true)
                    {
                        count++;
                    }
                }
                if (count > 3) flag = false;


                return flag;
            }
            public override void explain()
            {
                Console.WriteLine(" Contains special characters");
            }
        }
    }
}

