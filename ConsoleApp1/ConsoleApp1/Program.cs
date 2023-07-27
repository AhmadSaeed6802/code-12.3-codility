using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //char A = 'A';
            //char a = 'a';
            //Console.WriteLine(Convert.ToInt32(a));

            //Console.WriteLine(Convert.ToInt32(A));
            //Console.ReadLine();


        }
        1ST 12 CODILITY
        //    public string solution(string S)
        //    {
//        // Implement your solution here
//        string ret = "";
//        int[] counts = new int[S.Length];
//                for (int i = 0; i<S.Length; i++)
//                {
//                    for (int j= 0; j<S.Length; j++)
//                    {
//                        if(S[i]==S[j]&& i!=j)
//                        {
//                            ret = Convert.ToString(S[i]);
//                        }
//}


//                }
//                return ret;

        //}
    }
    public int solution(string letters)
    {
        // Implement your solution here
       
        int count = 0;
        for (int i = 0; i <letters.Length;i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if(letters[i].ToString().ToUpper()== letters[j].ToString().ToUpper() && i!=j )
                {
                    
                  if(  Convert.ToInt32(letters[i])> Convert.ToInt32(letters[j])&&i<j)
                    {
                        count++;
                    }
                    else if (Convert.ToInt32(letters[i]) < Convert.ToInt32(letters[j]) && i > j)
                    {
                        count++;
                    }
                     if (Convert.ToInt32(letters[i]) > Convert.ToInt32(letters[j]) && i > j)
                    {
                        count--;
                    }
                    else if (Convert.ToInt32(letters[i]) > Convert.ToInt32(letters[j]) && i < j)
                    {
                        count--;
                    }



                }
            }
        }

        return count;

    }
}

}
