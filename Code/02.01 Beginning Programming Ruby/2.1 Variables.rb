hi = "hello"

num = 23


puts "say something!"
something = gets
puts something

# Variables will change type!
some_number = "Ten"
some_number.class

# .class tells you what any object is at the moment
some_number = 10
some_number.class


#Lots of helpful things built in

some_number = "10"
some_number = some_number.to_i # to int, same as Convert.toInt in C#
some_number = "10".to_i # this also works
some_number = 10.to_s #going the other way now
some_number = "flerp".to_i #this will give you 0, instead of crashing

