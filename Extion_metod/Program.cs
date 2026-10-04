namespace Extion_metod
{

    /* public static class extionmethod
     {
         public static void fpreatch(this int[,] arr)
         {
             foreach (var item in arr)
             {
                 Console.WriteLine(item);
             }
         }
     }*/

    /* public static class extion
     {
         public static bool iseven(this int nump)
         {
             return nump %2==0;
         } 
     }*/

    public class item
    {
        
        public void check(int[] arr,Predicate<int> d)
        {
            foreach (var ite in arr)
            {
                if (d(ite))
                {
                    Console.WriteLine(ite);   
                }
            }
        }




    }


   // public delegate bool itemDelegate(int arr);
    public delegate int calc(int num11,int num2);
    internal class Program
    {

        public static bool ispostive(int num)
        {
            return num > 0;

        }
       
        

        public static int calck(int num1, int num2, calc c) {
        
            int res=c(num1, num2);
            return res;
        
        }
         public static int add(int num1,int num2) => num1 + num2;

        static void Main(string[] args)
        {
           // itemDelegate itt = new itemDelegate(ispostive);
            item it=new item();
            it.check([55, 565, -545, 654, -4461, -61888], (int num)=>num<0);
            //-----------------------

            calc cl= new calc(add);//1
            calc c= new calc((int numm1,int nummm2)=> numm1-nummm2);// 2- lamba exriton

            int saa = calck(10, 5, (int numm1, int nummm2) => numm1 - nummm2);// 3- no opject in delget
            Console.WriteLine(saa);




            int sam=calck(5,6,cl);
            Console.WriteLine(sam);
            int samm=calck(5,6,c);
            Console.WriteLine(samm);



           /* delprint d1=new delprint(printt);
            printt("ali");

            int m = 2;
            int s = 3;
            Console.WriteLine(m.iseven());
            Console.WriteLine(s.iseven());*/


        }
    }
}
