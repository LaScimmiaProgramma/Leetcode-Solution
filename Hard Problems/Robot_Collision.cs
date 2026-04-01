public class Solution {
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions) {
        // I use a stack to track the indices of robots moving right (R)
        // I process robots in order of position, not index, so I sort by position first
        // For each L robot, I simulate collisions against the top of the stack
        Stack<int> right = new Stack<int>();
        List<int> result = new List<int>();
        bool[] survived = new bool[positions.Length];

        // I sort indices by position so I process robots left to right
        int[] order = Enumerable.Range(0, positions.Length)
                        .OrderBy(i => positions[i])
                        .ToArray();

        for(int i = 0; i < positions.Length; i++){
            int idx = order[i];
            if(directions[idx] == 'R'){
                // I push R robots onto the stack, they are waiting for a potential collision
                right.Push(idx);
            }else{
                // I simulate the L robot fighting against R robots on the stack one by one
                while(healths[idx] > 0 && right.Count > 0){
                    if(healths[idx] > healths[right.Peek()]){
                        // I win against the R robot, I lose 1 health and keep fighting
                        healths[idx]--;
                        right.Pop();
                    }else if(healths[idx] < healths[right.Peek()]){
                        // I lose against the R robot, it loses 1 health and survives
                        healths[right.Peek()]--;
                        break;
                    }else{
                        // I tie with the R robot, we both die
                        right.Pop();
                        healths[idx] = 0;
                        break;
                    }
                }
                // I survive if I still have health and no more R robots to fight
                if(healths[idx] > 0 && right.Count == 0){
                    survived[idx] = true;
                }
            }
        }

        // I mark all R robots remaining on the stack as survivors
        List<int> survivors = new List<int>();
        while(right.Count > 0){
            survivors.Add(right.Pop());
        }
        survivors.Reverse();
        foreach(int idx in survivors){
            survived[idx] = true;
        }

        // I rebuild the result in the original input order
        for(int i = 0; i < positions.Length; i++){
            if(survived[i]){
                result.Add(healths[i]);
            }
        }
        return result;
    }
}
