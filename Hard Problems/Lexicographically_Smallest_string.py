class Solution(object):
    def generateString(self, str1, str2):
        n, m = len(str1), len(str2)
        total = n + m - 1
        # I initialize the result as all 'a' and track which positions are fixed by a 'T'
        word = ['a'] * total
        fixed = [False] * total

        # I first process all 'T' positions: I stamp str2 at each index and lock those characters
        # if a conflict is found with an already fixed character, I return ""
        for i in range(n):
            if str1[i] == 'T':
                for j in range(m):
                    if fixed[i + j] and word[i + j] != str2[j]:
                        return ""
                    word[i + j] = str2[j]
                    fixed[i + j] = True

        # I then process all 'F' positions: I check if str2 accidentally matches at this index
        # if it does, I break the match by changing the rightmost non-fixed character to 'b'
        # if all characters are fixed and the match cannot be broken, I return ""
        for i in range(n):
            if str1[i] == 'F':
                match = all(word[i + j] == str2[j] for j in range(m))
                if match:
                    broken = False
                    for j in range(m - 1, -1, -1):
                        if not fixed[i + j]:
                            word[i + j] = 'b' if word[i + j] == 'a' else word[i + j]
                            broken = True
                            break
                    if not broken:
                        return ""

        return ''.join(word)
