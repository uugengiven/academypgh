class Song
    @title
    @duration    
    
    attr_accessor :title
    attr_accessor :duration 
end

class Album
    @name
    @title
    @year
    @tracks
    
    def get_album
        result = "#{@name} (#{@year}) - #{@title}\n"
        @tracks.each do |track|
            result = result + "#{track.title} - #{track.duration} \n"
        end
        return result
    end
    
    def set_album(name, title, year, tracks)
        @name = name
        @title = title
        @year = year
        @tracks = tracks
    end
end