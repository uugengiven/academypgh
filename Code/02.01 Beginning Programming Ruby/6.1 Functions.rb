# How to function
# def name(any, variables)
# do some work
# end

def multiply(x, y)
	x * y
end

puts multiply(2, 3)

def new_grid()
	grid = Array.new(30){Array.new(30){true}}
	grid
end

grid = new_grid

def newGrid(size)
	grid = Array.new(size){Array.new(size){true}}
	grid
end

grid2 = new_grid(40)

def new_grid(size, default)
	grid = Array.new(size){Array.new(size){default}}
end

grid3 = new_grid(40, "1")

some_hash = {"name" => "John", "grade" => 100}
some_hash = {:name => "John", :grade => 100}
some_hash = {name: "John", grade: 100}

puts some_hash[:name]
some_hash[:car] = "Marauder"
some_hash[:name] = "James"

sheet2 = {"name" => "Jack", "grade" => 50, "failing", true}


