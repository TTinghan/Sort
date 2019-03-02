using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DNA
{
    class QuickSortt
    {
        //快速排序
        public void QuickSort(int[] R, int low, int high)
        {

            if (low < high)     //确保区间至少存在一个以上的元素
            {                   //temp表示基准值，这里是取区间的第一个元素作为它的值
               int  i = low, j = high, temp = R[i];
                while (i < j)   //从区间两端交替向中间扫描，直到i=j为止
                {
                    while (i < j && R[j] >= temp)
                    {
                        j--;   //从右向左扫描直到找到比基准值小的元素
                    }
                    R[i] = R[j];//将比基准值小的元素移到左端
                
                 while (i < j && R[i] <= temp)
                    {
                        i++;    //从向右扫描直到找到比基准值大的元素
                    }
                    R[j] = R[i];//将比基准值小的元素移到右端
                }
                R[i] = temp;    //记录归位
                QuickSort(R, low, i - 1);//对左区间递归排序
                QuickSort(R, i + 1, high);//对右区间递归排序
       }
              }

        }

    }
