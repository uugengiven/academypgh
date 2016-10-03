class RomanNumerals
    def initialize
        @roman_hash = {"X" => 10, "IX" => 9, "V" => 5, "IV" => 4, "I" => 1}
    end
    
    def convert(number)
        result = ""
        @roman_hash.each do |roman, arabic|
            while number >= arabic
                result += roman
                number -= arabic
            end
        end    
        return result
    end
end