func groupAnagrams(strs []string) [][]string {
    bigMap := make(map[int]map[byte]int)

    for i, element := range strs {
		smallMap := make(map[byte]int)
        if len(element) == 0 {
            smallMap['0'] = 1
        }

        for _, letter := range element {
		smallMap[byte(letter)]++
        }
		bigMap[i] = smallMap
    }
    
    var resultSlice [][]string
    var flag bool
    var resultOriginIndices []int

    for i, key := range strs {
        flag = false
        for sliceIdx, _ := range resultSlice {
            originIdx := resultOriginIndices[sliceIdx]
            if fmt.Sprint(bigMap[i]) == fmt.Sprint(bigMap[originIdx]) {
                resultSlice[sliceIdx] = append(resultSlice[sliceIdx], key)
                flag = true
                break
            }
        }

        if !flag {
            newSlice := []string{key}
            resultSlice = append(resultSlice, newSlice)
            resultOriginIndices = append(resultOriginIndices, i)
        }
    }

    return resultSlice
}