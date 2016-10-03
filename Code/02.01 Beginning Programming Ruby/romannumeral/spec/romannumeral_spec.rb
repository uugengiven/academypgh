require "romannumerals"

describe RomanNumerals do

    describe ".convert" do
    
        context "given the number 1" do
            it "returns I" do
                rn = RomanNumerals.new
                result = rn.convert(1)
                expect(result).to eql("I")
            end
        end
        
        context "given the number 2" do
            it "returns II" do
                rn = RomanNumerals.new
                result = rn.convert(2)
                expect(result).to eql("II")
            end
        end

        context "given the number 3" do
            it "returns III" do
                rn = RomanNumerals.new
                result = rn.convert(3)
                expect(result).to eql("III")
            end
        end

        context "given the number 4" do
            it "returns IV" do
                rn = RomanNumerals.new
                result = rn.convert(4)
                expect(result).to eql("IV")
            end
        end        

        context "given the number 5" do
            it "returns V" do
                rn = RomanNumerals.new
                result = rn.convert(5)
                expect(result).to eql("V")
            end
        end 

        context "given the number 7" do
            it "returns VII" do
                rn = RomanNumerals.new
                result = rn.convert(7)
                expect(result).to eql("VII")
            end
        end

        context "given the number 10" do
            it "returns X" do
                rn = RomanNumerals.new
                result = rn.convert(10)
                expect(result).to eql("X")
            end
        end 
        
        context "given the number 9" do
            it "returns IX" do
                rn = RomanNumerals.new
                result = rn.convert(9)
                expect(result).to eql("IX")
            end
        end

        context "given the number 33" do
            it "returns XXXIII" do
                rn = RomanNumerals.new
                result = rn.convert(33)
                expect(result).to eql("XXXIII")
            end
        end 

        context "given the number 28" do
            it "returns XXVIII" do
                rn = RomanNumerals.new
                result = rn.convert(28)
                expect(result).to eql("XXVIII")
            end
        end         
        end

end