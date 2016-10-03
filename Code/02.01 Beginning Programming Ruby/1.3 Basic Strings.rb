# Just like C# (almost)

puts "Hello" + " World"
puts "Hi, " + "Hello, " + "We can keep doing this"

# puts "Hello" + 2 #that gives an error in ruby!
puts "Hello" + 2.to_s #very similar to .toString() in C#

#Important to note that numbers like 1, 2, 50 all are objects
some_var = "hello!"
some_num = 12
puts "Some var #{some_var} and some num = #{some_num}"
