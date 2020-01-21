using System;
using System.Collections.Generic;
using System.Text;

namespace PracrticePlaybook
{
    /// <summary>
    /// Follow dynamic approach of collecting all the combinations and tabulating
    /// 
    /// 1. Ensure that the Order the Weights is sorted
    /// 2. Check by sets, if each could be included
    /// The Table is [items +1 , weights + 1] ie, considering combination of considering each item for the given wieight and increment weights and items to include
    /// SO at a point we have
    /// V[i][w] =  v[i-1, w] || v[i-1, w-w[i]+p[i]]
    /// Above says for Given Items Considered 
    /// https://www.youtube.com/watch?v=8LusJS5-AGo
    /// </summary>

    public class KnapSack01
    {
        int[] value = { 10, 50, 70 };
        int[] weight = { 10, 20, 30 };
        int capacity = 40;
        int itemsCount = 3;

        public KnapSack01() { 
        }
        public KnapSack01(int capacity, int count , int[] weights = null, int[] profits = null)
        {
            this.weight = weights;
            this.value = profits;
            this.capacity = capacity;
            this.itemsCount = count;
        }

        public int GetMaxValue() {

            int[,] K = new int[itemsCount + 1, capacity + 1];

            for (int i = 0; i <= itemsCount; ++i)
            {
                for (int currentWeight = 0; currentWeight <= capacity; ++currentWeight)
                {
                    if (i == 0 || currentWeight == 0)
                        K[i, currentWeight] = 0;
                    else if (weight[i - 1] <= currentWeight)
                        K[i, currentWeight] = Math.Max(value[i - 1] + K[i - 1, currentWeight - weight[i - 1]], K[i - 1, currentWeight]);
                    else
                        K[i, currentWeight] = K[i - 1, currentWeight];
                }
            }

            return K[itemsCount, capacity];
        }
    }
}
