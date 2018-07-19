
import { expect } from 'chai';
import Calculator from '../src/calc';

describe("Calculator", function() {

    describe("Add", function() {
        it("should return 0 when a = 0 and b = 0", function() {
            let calc = new Calculator();
            let result = calc.Add(0, 0);
            expect(result).to.equal(0);
        });
        it("should return 3 when a = 1 and b = 2", function() {
            let calc = new Calculator();
            let result = calc.Add(1, 2);
            expect(result).greaterThan(0);
            expect(result).to.equal(3);
        });
        it("should return -3 when a = -1 and b = -2", function() {
            let calc = new Calculator();
            let result = calc.Add(-1, -2);
            expect(result).lessThan(0);
            expect(result).to.equal(-3);
        });
    });

    describe("Subtract", function() {
        it("should return 0 when a = 0 and b = 0", function() {
            let calc = new Calculator();
            let result = calc.Subtract(0, 0);
            expect(result).to.equal(0);
        });
        it("should return -1 when a = 1 and b = 2", function() {
            let calc = new Calculator();
            let result = calc.Subtract(1, 2);
            expect(result).lessThan(0);
            expect(result).to.equal(-1);
        });
        it("should return 1 when a = -1 and b = -2", function() {
            let calc = new Calculator();
            let result = calc.Subtract(-1, -2);
            expect(result).greaterThan(0);
            expect(result).to.equal(1);
        });
    });

    describe("Multiply", function() {
        it("should return 0 when a = 0 and b = 0", function() {
            let calc = new Calculator();
            let result = calc.Multiply(0, 0);
            expect(result).to.equal(0);
        });
        it("should return 2 when a = 1 and b = 2", function() {
            let calc = new Calculator();
            let result = calc.Multiply(1, 2);
            expect(result).greaterThan(0);
            expect(result).to.equal(2);
        });
        it("should return 2 when a = -1 and b = -2", function() {
            let calc = new Calculator();
            let result = calc.Multiply(-1, -2);
            expect(result).greaterThan(0);
            expect(result).to.equal(2);
        });
    });

    describe("Divide", function() {
        it("should throw an error when a = 0 and b = 0", function() {
            let calc = new Calculator();
            expect(() => calc.Divide(0, 0)).to.throw(Error, 'Cannot divide by zero');
        });
        it("should return 0.5 when a = 1 and b = 2", function() {
            let calc = new Calculator();
            let result = calc.Divide(1, 2);
            expect(result).greaterThan(0);
            expect(result).to.equal(0.5);
        });
        it("should return 0.5 when a = -1 and b = -2", function() {
            let calc = new Calculator();
            let result = calc.Divide(-1, -2);
            expect(result).greaterThan(0);
            expect(result).to.equal(0.5);
        });
    });

});
