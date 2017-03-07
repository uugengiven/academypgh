# Convert text into morse code


morse_hash = {
	"A" => ".- ",
	"B" => "-... ",
	"C" => "-.-. ",
	"D" => "-.. "
}


puts "Enter your text!"
gets.chomp.upcase.each_char do |character|
    print morse_hash[character]
end