using System;

namespace AlgorithmSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Algorithm!");

            //斐波那契数列和
            Stopwatch(new Action(()=> 复杂度.复杂度.FibonacciNumberMine(30)), "自己用递归实现");
            Stopwatch(new Action(() => 复杂度.复杂度.FibonacciNumberMJ(30, 0, 1)), "mj算法实现");
        }
        /// <summary>
        /// 计算时间
        /// </summary>
        /// <param name="function">要被执行的代码</param>
        /// <returns>执行这一段代码耗时，单位：毫秒</returns>
        static void Stopwatch(Action function,string title)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            //开始执行业务代码
            function();

            sw.Stop();
            TimeSpan timeSpan = sw.Elapsed;

            Console.WriteLine(string.Format("{0}:{1}ms", title, timeSpan.TotalMilliseconds));
        }
    }
}
 