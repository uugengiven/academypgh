require "./lib/romannumerals"

my_roman_numerals = RomanNumerals.new

puts "Enter a number, I will convert it to roman numerals"
number = gets.chomp

puts my_roman_numerals.convert(number.to_i)