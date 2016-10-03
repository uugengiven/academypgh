if true
	puts "This will happen once"
end

looping = true
counter = 0
string_var = "some string"

while looping
	puts "We are on number #{counter} and here is #{string_var}"
	counter = counter + 1
	if counter > 100
		looping = false
	end
end

#until false #this way you don't need a while !, it makes it more like english
#	puts "This will never end either!"
#end
# if divisble by 3, write fizz
# if divisble by 5, write buzz
# if divisble by both, write fizzbuzz
# else write the number