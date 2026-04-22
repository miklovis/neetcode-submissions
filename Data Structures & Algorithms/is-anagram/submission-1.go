func isAnagram(s string, t string) bool {
    var sMap map[byte]int
    var tMap map[byte]int

    sMap = make(map[byte]int)
    tMap = make(map[byte]int)

    if (len(s) != len(t)) {
        return false
    }

    for i := 0; i < len(s); i++ {
        sMap[s[i]]++
        tMap[t[i]]++
    }

    if fmt.Sprint(sMap) == fmt.Sprint(tMap) {
        return true
    }
    return false
}
