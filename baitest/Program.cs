using System;
using System.Linq;
namespace baitest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" moi nhap mang");

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];


            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

          
            int maxLength = -1;
            int startPos = 0; int  starPos2 = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                count++;
                if (i + 1 < arr.Length)
                {
                    if (arr[i] > arr[i + 1])   // 1 7 9 2 4 7 3 5 6
                    {
                        if (count > maxLength) // mảng con tăng dần
                        {
                            maxLength = count;
                            startPos = i + 1 - maxLength;
                            for (int k = startPos; k < startPos + maxLength; k++)
                            {
                                Console.Write(arr[k] + " ");
                            }

                            Console.WriteLine(" ");
                        }

                        else
                        {
                            if (count == maxLength) // mảng con tăng dần trùng độ dài
                            {

                                starPos2 = i + 1 - maxLength;
                               // Console.WriteLine("startpos2 " + starPos2);
                                for (int k = starPos2; k < starPos2 + maxLength; k++)
                                {
                                    Console.Write(arr[k] + " ");
                                }
                                Console.WriteLine(" ");
                               

                            }
                        
                        }
                               

                        count = 0;
                    }
                }
              
            }
            if (maxLength == -1)
            {
                maxLength = arr.Length;
            }
           
           
            Console.WriteLine();
        }
    }
}








