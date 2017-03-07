class Im_a_class
    @im_a_class_variable    
    # attr_accessor :im_a_class_variable    

	
    def im_a_class_function
        @im_a_class_variable = ["one", "two"]
    end
    
    def get_variable
        @im_a_class_varible
    end

    def initialize
        @im_a_class_variable = "Started"
    end
    

end

some_var = Im_a_class.new
some_var.im_a_class_function

puts some_var.im_a_class_variable #this will fail
