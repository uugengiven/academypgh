require "./romannumerals"

translator = RomanNumerals.new

puts "Give me a number and I'll write it in Roman Numerals!"
result = gets
puts translator.to_r(result.to_i)
