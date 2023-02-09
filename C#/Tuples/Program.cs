namespace Tuples
{
    class Program
    {
        //public static (int, int) foo(ref int num1, ref int num2)
        //{
        //    int tmp = num1;
        //    num1 += num2;
        //    num2 += tmp;

        //    return (num1, num2);
        //}




        public static void Main()
        {
            #region Tuples1

            // Example 1
            var tuple1 = (1, 2, 3, 4);

            // Example 2
            Tuple<int, string, int, string, List<int>> tuple2 = new(1, "2", 3, "4", new() { 1, 2, 3, 4, 5 });

            // Example 3
            var tuple3 = new Tuple<int, string, int, string>(1, "2", 3, "4");

            // Example 4

            Tuple<int, string, int, string, Tuple<Dictionary<string, int>>> tuple4 =
                new(
                    1, "2", 3, "4",
                    new(new() { { "Elvin", 12 }, { "Ilkin", 12 } })
                    );

            #endregion

            #region Tuples2

            //int a = 1;
            //int b = 2;

            //Console.WriteLine($"{a} {b} - Before");

            //(int, int) res = foo(ref a, ref b);

            //Console.WriteLine($"{a} {b} - After");

            //Console.WriteLine(res + "Returned");

            #endregion

            #region Tuples3

            //List<int> nums = new() { 4, 3, 2, 1 };


            //for (int i = 0; i < nums.Count; i++)
            //{
            //    for (int j = i + 1; j < nums.Count; j++)
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            (nums[i], nums[j]) = (nums[j], nums[i]);
            //        }
            //    }
            //}


            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
}


