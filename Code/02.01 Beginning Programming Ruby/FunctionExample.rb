# Functions

def multiply x, y
	x * y
end

def say_hello_to_bridget
	puts "Hello Bridget"
end

puts multiply 2, 3
say_hello_to_bridget
puts multiply "hello", 5

my_file = File.read("template.txt")

body = "This is the real body of my blog."

puts my_file