require "romannumerals"

describe RomanNumerals do

    describe ".to_r" do
        context "given the number 1" do
            it "returns I" do
                rn = RomanNumerals.new
                expect(rn.to_r(1)).to eql("I")
            end
        end
        
        context "given the number 2" do
            it "returns II" do
                rn = RomanNumerals.new
                expect(rn.to_r(2)).to eql("II")
            end
        end
    end
end