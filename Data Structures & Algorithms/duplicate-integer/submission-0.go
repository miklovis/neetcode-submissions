func hasDuplicate(nums []int) bool {
    var m map[int]bool
    m = make(map[int]bool)

    for _, element := range nums {
        
        if m[element] {
            return true
        } else {
            m[element] = true
        }
    }

    return false
}
