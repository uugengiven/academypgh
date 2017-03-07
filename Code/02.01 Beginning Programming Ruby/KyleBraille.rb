puts "Enter your message:"

x =           ["a",   "b",   "c",   "d",   "e",   "f",   "g",   "h",   "i",   "j",   "k",   "l",   "m",   "n",   "o",   "p",   "q",   "r",   "s",   "t",   "u",   "v",   "w",   "x",   "y",   "z",   " ",  "."]
top_line =    ["*0 ", "*0 ", "** ", "** ", "*0 ", "** ", "** ", "*0 ", "0* ", "0* ", "*0 ", "*0 ", "** ", "** ", "*0 ", "** ", "** ", "*0 ", "0* ", "0* ", "*0 ", "*0 ", "0* ", "** ", "** ", "*0 ", "  ", "   "]
middle_line = ["00 ", "*0 ", "00 ", "0* ", "0* ", "*0 ", "** ", "** ", "*0 ", "** ", "00 ",   "*0 ", "00 ", "0* ", "0* ", "*0 ", "** ", "** ", "*0 ", "** ", "00 ", "*0 ", "** ", "00 ", "0* ", "0* ", "  ", "   "]                                                                 
bottom_line = ["00 ", "00 ", "00 ",   "00 ", "00 ", "00 ", "00 ", "00 ", "00 ", "00 ", "*0 ", "*0 ", "*0 ", "*0 ", "*0 ", "*0 ", "*0 ", "*0 ", "*0 ", "*0 ", "** ", "** ", "0* ", "** ", "** ", "** ", "  ", "   "]                                                 

originalmessage = gets.chomp.downcase



originalmessage.each_char do |character|
    
     (0...top_line.length).each do |i|
        if x[i] == character
            print top_line[i]
        end
    end
end
puts 
originalmessage.each_char do |character|
    
     (0...middle_line.length).each do |i|
        if x[i] == character
            print middle_line[i]
        end
    end
end
puts
originalmessage.each_char do |character|
    
     (0...bottom_line.length).each do |i|
        if x[i] == character
            print bottom_line[i]
        end
    end
end