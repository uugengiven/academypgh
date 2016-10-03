for i in 1..5
	puts i
end

for i in 20..38
	puts i
end

(1..10).each do |i|
	if i.even?
		next
	end
	puts i
end

firstTime = true

(1..10).each do |i|
	puts i
	if i == 3 && firstTime
		firstTime = false
		redo
	end
end