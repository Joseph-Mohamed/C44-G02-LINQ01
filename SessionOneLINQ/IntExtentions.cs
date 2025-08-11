namespace SessionOneLINQ
{

    //extention method must be added to static class and non genaric class
    internal static class IntExtentions
    {


        public static string ToString(this int x)
        {
            return $"Hello from method toString";
        }

        //public static int ReverseNum(this int num)
        //{
        //    int reminder = 0, reversNum = 0 ;
        //    while(num!=0)
        //    {
        //        reminder = num % 10;
        //        reversNum = reversNum * 10 + reminder;
        //        num = num / 10;
        //    }
        //    return reversNum;
        //}


        //public static long ReverseNum(this long num)
        //{
        //    long reminder = 0, reversNum = 0;
        //    while (num != 0)
        //    {
        //        reminder = num % 10;
        //        reversNum = reversNum * 10 + reminder;
        //        num = num / 10;
        //    }
        //    return reversNum;
       // }
    }
}
