class Greeting
	attr_accessor :class_greetings

	def say_hello
		puts @class_greetings
	end
	
	def set_greetings(greetings)
		@class_greetings = greetings
	end
	
	def initialize
		@class_greetings = "Hello from the constructor!"
	end

end


greeter = Greeting.new
greeter.say_hello

walmart_greeter = Greeting.new
walmart_greeter.set_greetings("Welcome to Walmart")
walmart_greeter.say_hello

 .say_hello

