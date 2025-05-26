public class Solution {
    public int MaxProfit(int[] prices) {
        int ptrLeft=0;
        int ptrRight=0;

        int maxProfit = 0;
        while(ptrRight<prices.Length){
            if(prices[ptrLeft]>prices[ptrRight]){
                ptrLeft = ptrRight;
            }
            else
            maxProfit = Math.Max(maxProfit, prices[ptrRight] - prices[ptrLeft]);

            ptrRight++;
        }
        return maxProfit;
    }
}