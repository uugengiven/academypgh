# Morse Code Project

# Morse Code
# Input a string from the user
# Output the string as Morse Code
# Use a single space to separate letters
# Use a double space to separate words
def get_morse(message)
morse_key = {
	"a" => ".-",
	"b" => "-...",
	"c" => "-.-.",
	"d" => "-..",
	"e" => ".",
	" " => " ",
	"z" => "--..",
	"v" => "...-",
	"." => "  "
}

message.each_char do |character|
	print morse_key[character]
	print " "
end

puts "Enter your string"
user_string = gets.chomp.downcase
get_morse(user_string)

