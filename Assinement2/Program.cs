using System;
namespace Test
{
    class Prasad
    {
     
        public static void Main()
        {
            
            int[] a = { 1, 2, 3, 4, 5, 6, 8, 9, 8, 7, 4, 5, 8, 7, 4, 4, 5, 7, 4, 6, 6, 4, 5, 5, 4 };
            String s = " ";
            int[] arr = new int[a.Length-1];
           
            for (int i = 0; i < a.Length - 1; i++)
            {


                if (a[i] + 1 == a[i + 1] || a[i] - 1 == a[i + 1] || a[i] == a[i - 1] + 1 || a[i] == a[i - 1] - 1)

                {
                    s = s + a[i];


                    arr[i] = a[i];
                }

                Console.Write(" " + arr[i]);
            }
            char[]ch = s.ToCharArray();
            int max=0,min=0,m=0;
            for (int i = 1; i < arr.Length; i++)

            {

                if (arr[i] > max)
                {
                    max = arr[i];


                }
            }
             Console.WriteLine();
            Console.WriteLine("maximum"+"="+max);
            if (max == 9)
            {
                max = max - 1;
            }


            for (int i = 0; i < arr.Length; i++)
            {

                if (max == arr[i] - 1)
                {
                    min = max * arr[i];
                }
               else if (max == arr[i] + 1)
                {
                    m = max * arr[i];
                }
            }

               // Console.Write( + min);
            

                Console.WriteLine(  + min * m);
        }
            
        
    }
}