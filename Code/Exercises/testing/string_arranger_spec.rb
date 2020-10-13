require "stringarrange"

describe String_Arranger do
    describe ".arrange" do
        context "when given cba" do
            it "returns abc" do
                sa = String_Arranger.new
                expect(sa.arrange("cba")).to eql("abc")
            end
        end
        context "when given hello" do
            it "returns ehllo" do
                sa = String_Arranger.new
                expect(sa.arrange("hello")).to eql("ehllo")
            end
        end
        context "when given an empty string" do
            it "returns an empty string" do
                sa = String_Arranger.new
                expect(sa.arrange("")).to eql("")
            end
        end
        context "when given a single letter" do
            it "returns that same letter" do
                sa = String_Arranger.new
                expect(sa.arrange("a")).to eql("a")
            end
        end
        context "when given a sentece with spaces" do
            it "returns the letters in order with no spaces" do
                sa = String_Arranger.new
                expect(sa.arrange("hello there")).to eql("eeehhllort")
            end
        end
        context "when using punctuation and numbers" do
            it "returns only letters, in order" do
                sa = String_Arranger.new
                expect(sa.arrange("hel!0lo.,%$ (*")).to eql("ehllo")
            end
        end
        context "when using uppercase" do
            it "returns all characters as lowercase and in order" do
                sa = String_Arranger.new
                expect(sa.arrange("Hello")).to eql("ehllo")
            end
        end
    end
end
