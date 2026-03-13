public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int closest = nums[0] + nums[1] + nums[2];
        for(int i=0; i<nums.Length-2; i++){
            if(i > 0 && nums[i] == nums[i-1]) continue;
            int L = i+1;
            int R = nums.Length-1;
            while(L<R){
                int sum = nums[i] + nums[L] + nums[R];
                if(Math.Abs(sum - target) < Math.Abs(closest - target)) closest = sum;
                if(sum < target) L++;
                else if(sum > target) R--;
                else return sum;
            }
        }
        return closest;
    }
}