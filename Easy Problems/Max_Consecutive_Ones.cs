public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0; 
        int Max = 0;
        for(int i=0; i<nums.Length; i++){
            if(nums[i]==1){
                count++;
            }else{
                if(count>Max) Max=count;
                count = 0;
            }
        }
        return Math.Max(Max, count);
    }
}