some_array = [1, 323, 5, [232, "Hi!", 4], 3]

some_array << 5
some_array << "Hello"

some_array.push(3)
some_array.push(true)
some_array.push("This is a string")

some_array.each do |i|
	puts i
end

#puts some_array