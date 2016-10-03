if true
	puts "True!"
end
	
if 5 > 2
	puts "Comparitivies"
end

if "A" > "2"
	puts "Uhh, what?" #it's looking at the ASCII value/alphabetically
end

test_snake = 3

case test_snake
	when 1
		puts "1!"
	when 2, 3, 4
		puts "2-4?"
	when 5
		puts "fiver!"
	when 6
		puts "sixes"
end
puts "Some var #{test_snake} and some num = #{test_snake + 5}"