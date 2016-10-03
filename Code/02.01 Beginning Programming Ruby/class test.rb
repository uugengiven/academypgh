require './album'

song_array = []
song = Song.new
song.title = "Purple Rain"
song.duration = "3:53"
song_array << song

song = Song.new
song.title = "1999"
song.duration = "4:12"
song_array << song


prince = Album.new
prince.set_album "Prince", "1999", 1993, song_array
puts prince.get_album
