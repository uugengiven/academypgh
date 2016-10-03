class RomanNumerals

    def to_r number
        # Turn an int into the roman numeral equivelent
        result = ""
        while number >= 5
            number -= 5
            result += "V"
        end
        while number >= 4
            number -= 4
            result += "IV"
        end
        while number >= 1
            number -= 1
            result += "I"
        end
        result
    end
end