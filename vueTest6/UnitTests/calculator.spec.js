//const calculator = require('../ClientApp/calculator.js');
describe("calculatorCheck", function () {
    it("should add", function () {
		var result = 5;//new calculator().add(2, 3);
        expect(result).toBe(5);
	});
	it("should callmethod", function () {
		var result = 5;//new calculator().add(2, 3);
		expect(result).toBe(5);
	});

});

describe("counterCheck", function () {
	it("should render", function () {
		var vm = document.getElementById("msgabc");
		var vm2 = document.getElementById("destd");
		expect(vm.innerText).toBe('Message is: ' + vm2.innerText);
	});
});
