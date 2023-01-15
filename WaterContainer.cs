using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    public class WaterContainer //Вам предоставляется целочисленный массив heightдлины n. Существуют nвертикальные линии , нарисованные таким образом , что две конечные точки ithлинии равны (i, 0)и (i, height[i]).
                                  //Найдите две линии, которые вместе с осью x образуют контейнер, такой, чтобы в контейнере было больше всего воды.
                                  //Верните максимальное количество воды, которое может вместить контейнер.
    { 
        public int MaxArea(int[] height)
        {
            int indexLeft = 0;
            int indexRight = height.Length - 1;
            int maxArea = 0;
            while(indexLeft < indexRight)
            {
                int width = indexRight - indexLeft;
                maxArea = Math.Max(maxArea,Math.Min(height[indexLeft], height[indexRight]) * width);
                if (height[indexLeft] > height[indexRight]) indexRight--;
                else indexLeft++;
            }
            return maxArea;
        }
    }
}
