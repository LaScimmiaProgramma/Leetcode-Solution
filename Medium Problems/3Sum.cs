public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for(int i=0; i<nums.Length-2; i++){
            if(i > 0 && nums[i] == nums[i-1]) continue;
            int R=nums.Length-1;
            int L=i+1;
            while(L<R){
                if(nums[i]+nums[L]+nums[R]<0) L++;
                else if(nums[i]+nums[L]+nums[R]>0) R--;
                else {
                    result.Add(new List<int> { nums[i], nums[L], nums[R] });
                    L++;
                    R--;
                    while(L < R && nums[L] == nums[L-1]) L++;
                    while(L < R && nums[R] == nums[R+1]) R--;
                }
            }
        }
        return result;
    }
}