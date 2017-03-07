require './converter'

convert = RomanConverter.new
puts "Enter a number to convert: "
number = gets.chomp.to_i
puts convert.convert(number)
