public class Solution {
    public bool IsHappy(int n) {
        int sum=0;
        HashSet<int>mp=new HashSet<int>();
        while(n!=0){
             
             if(n==1)return true;
             if(mp.Contains(n))return false;
             mp.Add(n);
            while(n>0){
            sum+=(n%10)*(n%10);
             n=n/10;
            }
            n=sum;
            sum=0;

        }

        return n==1;
    }
}