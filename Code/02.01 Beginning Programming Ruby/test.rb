message_array = []
keep_looping = true
def is_number (number)
  true if Integer(number) rescue false
end
while keep_looping
  puts "Would you like to [A] save a message, [B] retrieve a message, or [C] exit?"
  choice = gets.chomp.downcase
  if choice == "a"
    puts "Type in your message:"
    message = gets.chomp
    mesage_array << message
    message_array.each do |i|
      if message_array[i] == message
        puts "Your message is at ID ##{i}"
        next
      end
	end
  elsif choice == "b"
    puts "Type in your message ID:"
    id = gets.chomp.to_i
    if is_number(id) && id < message_array.length && id >= 0
      puts "Your message is: #{message_array[id]}"
    end
  elsif choice == "c"
    keep_looping = false
  else
    puts "Invalid choice"
  end
end