public class Solution {
    private int[] parent;
    private int[] rank;

    public void Init(int size) {
        parent = new int[size];
        rank = new int[size];
        for (int i = 0; i < size; i++)
            parent[i] = i;
    }

    public int Find(int i) {
        if (parent[i] != i)
            parent[i] = Find(parent[i]);
        return parent[i];
    }

    public bool Union(int i, int j) {
        int irep = Find(i);
        int jrep = Find(j);
        if (irep == jrep) return false;
        if (rank[irep] < rank[jrep]) parent[irep] = jrep;
        else if (rank[irep] > rank[jrep]) parent[jrep] = irep;
        else { parent[jrep] = irep; rank[irep]++; }
        return true;
    }

    private bool IsAchievable(int X, int[][] edges, int n, int k) {
        Init(n);
        int edgesAdded = 0;
        int upgradesUsed = 0;

        foreach (var e in edges.Where(e => e[3] == 1)) {
            if (e[2] < X) return false;
            if (!Union(e[0], e[1]))
                return false;
            edgesAdded++;
        }

        foreach (var e in edges.Where(e => e[3] == 0 && e[2] >= X)) {
            if (Union(e[0], e[1]))
                edgesAdded++;
        }

        foreach (var e in edges.Where(e => e[3] == 0 && e[2] < X && e[2] * 2 >= X)) {
            if (upgradesUsed >= k) continue;
            if (Union(e[0], e[1])) {
                edgesAdded++;
                upgradesUsed++;
            }
        }

        return edgesAdded == n - 1;
    }

    public int MaxStability(int n, int[][] edges, int k) {
        var candidates = edges
            .SelectMany(e => new[] { e[2], e[2] * 2 })
            .Distinct()
            .OrderBy(x => x)
            .ToList();

        if (!IsAchievable(0, edges, n, k))
            return -1;

        int lo = 0, hi = candidates.Count - 1, answer = -1;
        while (lo <= hi) {
            int mid = (lo + hi) / 2;
            if (IsAchievable(candidates[mid], edges, n, k)) {
                answer = candidates[mid];
                lo = mid + 1;
            } else {
                hi = mid - 1;
            }
        }

        return answer;
    }
}