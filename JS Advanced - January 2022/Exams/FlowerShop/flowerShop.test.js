let flowerShop = require("./flowerShop.js");
let { expect } = require('chai');

describe("Flower Shop", function () {
    describe("Calculate price of flowers", function () {
        it("Should throw exception of invalid input", () => {
            expect(() => flowerShop.calcPriceOfFlowers(1, 1, 2)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers("flower", 1.2, 2)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers("flower", 1, 2.2)).to.throw(Error, 'Invalid input!');
        });

        it("Should calculate properly price", () => {
            expect(flowerShop.calcPriceOfFlowers('flower', 10, 2)).to.equal(`You need $20.00 to buy flower!`);
        });
    });

    describe("Check flower availability", () => {
        it("Should return flowers are available", () => {
            expect(flowerShop.checkFlowersAvailable('flower', ['flower1', 'flower2', 'flower'])).to.equal(`The flower are available!`);
        });
        it("Should say flowers are sold, you need more", () => {
            expect(flowerShop.checkFlowersAvailable('flower', ['flower1', 'flower2', 'flower3'])).to.equal(`The flower are sold! You need to purchase more!`);
        });
    });

    describe("Sell flowers", () => {
        it("Should throw error if invalid input", () => {
            expect(()=>flowerShop.sellFlowers(3,2)).to.throw(Error,'Invalid input!');
            expect(()=>flowerShop.sellFlowers([],2)).to.throw(Error,'Invalid input!');
            expect(()=>flowerShop.sellFlowers(['flower'],'2')).to.throw(Error,'Invalid input!');
            expect(()=>flowerShop.sellFlowers(['flower'],-1)).to.throw(Error,'Invalid input!');
        });

        it("Should sell flowers",()=>{
            expect(flowerShop.sellFlowers(['flower1', 'flower2', 'flower3'],2)).to.equal('flower1 / flower2')
        });
    });
});