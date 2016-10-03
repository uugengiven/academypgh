some_array = ["hi", 23, "hello?", [1, 2, 3]]
some_array << 5 # adds to the end of an array
puts some_array

puts some_array[3][2]

puts some_array.first
puts some_array.last

puts some_array[-1] #this goes from the end, -1 is the last element in an array

some_array.delete 23
puts some_array
size = gets.to_i
new_array = Array.new(30){Array.new(30){false}}

(0..29).each do |i|
	(0..29).each do |j|
	print new_array[i][j]
	end
	puts
end

new_array.each do |i|
	i.each do |j|
	print j
	end
	puts
end

some_hash = {"name" => "John", "grade" => 100}
some_hash = {:name => "John", :grade => 100}
some_hash = {name: "John", grade: 100}

