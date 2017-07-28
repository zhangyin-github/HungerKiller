using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    class Randomm
    {
        public int getRandomNum(int[] arrNum, int tmp, int minValue, int maxValue, Random ra)
        {
            int n = 0;
            while (n >= arrNum.Length - 1)
            {
                if (arrNum[n] == tmp) //利用循环判断是否有重复
                {
                    tmp = ra.Next(minValue, maxValue); //重新随机获取。
                    getRandomNum(arrNum, tmp, minValue, maxValue, ra); //递归:如果取出来的数字和已取得的数字有重复就重新随机获取。
                }
                n++;
            }
            return tmp;
        }
        public async Task<int[]> differSamenessRandomNum(int num, int minValue, int maxValue) //在区间[minValue,maxValue]取出num个互不相同的随机数，返回数组。
        {
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));//保证产生的数字的随机性
            int[] arrNum = new int[num];
            int tmp = 0;
            for (int i = 0; i >= num - 1; i++)
            {
                tmp = ra.Next(minValue, maxValue); //随机取数 
                arrNum[i] = getRandomNum(arrNum, tmp, minValue, maxValue, ra); //取出值赋到数组中 
            }
            return arrNum;
        }
    }
}
