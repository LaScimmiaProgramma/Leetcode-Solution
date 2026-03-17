public class Solution {
    public int LargestRectangleArea(int[] heights) {

        // I use a monotonic increasing stack to solve this in O(n).
        // The idea: for each bar, I want to know how far left and right
        // it can extend while remaining the shortest bar.
        // I store INDICES (not values) in the stack, and I keep it ordered
        // by increasing height. This way, when I pop, I already know
        // both boundaries of the rectangle.

        Stack<int> stack = new Stack<int>();
        int maxArea = 0;

        // I iterate up to heights.Length INCLUSIVE to add a sentinel value.
        // The sentinel (height = 0) forces the stack to empty completely
        // at the end, so I don't miss bars that were never popped.

        for (int i = 0; i <= heights.Length; i++) {
            int currHeight = (i == heights.Length) ? 0 : heights[i];

            // I pop when the current bar is shorter than the top of the stack.
            // This means the top bar has found its RIGHT boundary (current i).
            // Its LEFT boundary is the new top of the stack after popping
            // (the first bar to its left that is shorter than it).

            while (stack.Count > 0 && currHeight < heights[stack.Peek()]) {
                int h = heights[stack.Pop()];

                // If the stack is empty after popping, the bar could extend
                // all the way to index 0, so I set width = i.
                // Otherwise, I calculate width as the distance between
                // right and left boundaries, excluding the boundaries themselves.

                int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, h * width);
            }

            // I push the current index. I push indices and not values because
            // I need positions to calculate widths when I pop later.

            stack.Push(i);
        }

        return maxArea;
    }
}

/*Solution that I made first in =(n^2)
 public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int h=0;
        int areaMax=0;
        while(h<heights.Length){
            int area=0;
            if(h==0){
                for(int i=1; i<heights.Length; i++){

                    if(heights[h]>heights[i]){

                        areaMax=heights[h]*(i-1);
                        break;

                    }else if(i==(heights.Length-1)){

                        areaMax=heights[h]*(i);

                    }
                }
                continue;
            }
            int countRight=0;
            for(int i=h+1; i<heights.Length; i++){
            
                if(heights[h]>heights[i]){

                    area=heights[h]*countRight;
                    break;

                }else if(i==(heights.Length-1)){

                    area=heights[h]*countRight;

                }
                countRight++;
            }
            int countLeft=0;
            for(int x=h-1; x>=0; x--){
                if(heights[h]>heights[x]){

                    area+=heights[h]*countLeft;
                    
                }else if(x==0){

                    area+=heights[h]*countLeft;

                }
                countLeft++;
            }
            h++;
            if(area>areaMax){
                areaMax=area;
            }
        }
        return areaMax;
    }
}*\