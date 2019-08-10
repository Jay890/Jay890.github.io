/// SIMPLE CALCULATOR ///

var firstNumber = prompt("What is your first number?:");

var choice = prompt("What do you want to do?: add, subtract, multiply or divide");

var secondNumber = prompt("What is your second number?:");


if ( choice == "add" ){
	var add = (Number(firstNumber) + Number(secondNumber));
	alert(add);
} 
else if (choice == "subtract" ){
	var subtract = Number(firstNumber) - Number(secondNumber);
	alert("Sum is equal to " + subtract);
}
else if (choice == "multiply" ) {
	var multiply = Number(firstNumber) * Number(secondNumber);
	alert("Sum is equal to " + multiply);
}
else if (choice == "divide" ) {
	var divide = Number(firstNumber) / Number(secondNumber);
	alert("Sum is equal to " + divide);
}
