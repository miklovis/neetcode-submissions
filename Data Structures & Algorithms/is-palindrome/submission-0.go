func isPalindrome(s string) bool {
    var str *string = &s
    *str = strings.ToLower(*str)

    fmt.Println(*str)
    
    for i := 0; i < len(*str); i++ {
        if !isAlphanumeric((*str)[i]) {
            *str = strings.ReplaceAll(*str, string((*str)[i]), "")
            i--
        }
    }

    reversed := "" 
    var strReversed *string = &reversed

    for i := len(*str) - 1; i >= 0; i-- {
        *strReversed = *strReversed + string((*str)[i])
    }

    return *str == *strReversed
}

func isAlphanumeric(c byte) bool {
    return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')
}
