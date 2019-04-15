using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSharp.复杂度
{
    public class 复杂度
    {
        /// <summary>
        /// 自己思考的斐波那契数列的第n项(1+2+3+5+8...n前,一直加前面两项之和n,m,n+m,2m+n,3m+2n)算法,递归 
        /// 复杂度:O(2^n) 算复杂度,重复调用了 ,分析在mindzip上
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long FibonacciNumberMine(int n)
        {
            //if (n<0)
            //{
            //    return -1;
            //}
            if(n<=1)//if (n==0||n==1) 
            {
                return n;
            }
            return  FibonacciNumberMine(n - 1)+ FibonacciNumberMine(n - 2);
        } 

        /// <summary>
        /// 如果索引从1开始，斐波那契可理解为第n项需要相加n-2次（其实就是需要>2才可以构成数列）如下：
        /// 现在索引从0开始所以是n-1次
        /// 相加次数  0 0 1 2 3 4
        /// index     0 1 2 3 4 5 
        /// 值        0 1 1 2 4 8
        /// 复杂度 1+(1+n-1)*3 >>O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long FibonacciNumberMJ(int n,int first,int second)//我觉得前两位不一定是0，1所以改下
        {
            if (n<=1)
            {
                return n;
            }
            for (int i = 0; i < n-1; i++)
            {
                int sum = first + second;
                first = second;
                second = sum;
            }
            return second;
        }

        /**
         * 如何评判一个算法的好坏
         * 事后统计法:比较不同算法对同一组输入的执行处理时间
         *          缺点:硬件等不确定环境因素,测试数据难保公正
         * 一般从以下维度来评估算法的优劣
         * 正确性,可读性,健壮性(对不合理输入的反应能力)//基础
         * 时间复杂度(time complexity):估算程序指令的执行次数(执行时间)
         * 空间复杂度(space complexity):估算所需占用的存储空间 (int x=?之类)
         * 大O表示法 表示数据规模n对应的复杂度
         * 忽略常数,系数,低阶:
         * 常数 9 >> O(1)
         * 2n+3 >> O(n)
         * n²+2n+6 >> O(n²)
         * 4n³+3n²+22n+100 >> O(n³)
         * 对数阶的细节 log2n = log29 ∗ log9n :所以统称为 logn >>O(logn)
         * 大O仅仅是一种粗略的分析模型,是一种估算用来短时间计算一个算法的执行效率
         */
    }
}
