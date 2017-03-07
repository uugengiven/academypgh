info_hash = {
	"author:" => "Harry", 
	"book_name:" => "Never Ending Story", 
	"city:" => "Philadelphia"
	}
	
my_file = File.read("template.txt")


	def transfer replacement_hash, template_string
		replacement_hash.each_pair do |index, value|
			template_string.gsub!(index, value)
		end
		return template_string
	end

# puts "The book author is #{info_hash[:author]}"
puts transfer info_hash, my_file