class RomanConverter
	def convert(number)
	result = ""
	@denominations.each do |denomination|
		while number >= denomination[:value]
			number -= denomination[:value]
			result << denomination[:name]
		end
	end
	result
	end
	
	def initialize
		@denominations = []
		
		add_denomination("C", 100)
		add_denomination("I", 1)
	end
	
	def add_denomination(name, value)
		@denominations << {name: name, value: value}
	end
end