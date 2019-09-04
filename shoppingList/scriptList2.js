var input = document.getElementById("userInput");
var button = document.getElementById("enter");

var ul = document.querySelector("ul");

///
/// A lot of the code in the two function for the events is the same
/// We should follow DRY method to not repreat code
/// So we should refactor the code 
///

//In the two events the if statement is the same 
//if (input.value.length > 0

//SO WE CAN ADD A FUNCTION FOR THAT 

//we need to remember that as a function we need to return something otherwise the it will say undefined
function inputLength() {
	return input.value.length;
}

function createListElement() {
	var li = document.createElement("li");
		li.appendChild(document.createTextNode(input.value));
		ul.appendChild(li);
		input.value = "";
}


// button.addEventListener("click", function(){
// 	console.log("working");
// })


// button.addEventListener("click", function() {
// 	//we can have it so that if the textarea is empty it wont add anything
// 	if (inputLength() > 0) {
//  	createListElement();
// 	}
// })	


//but it is slow that we have to click enter everytime
//would be nice if we could hit enter key. 
//We could listen to the keypress event

//Look on JavaScript char codes (key codes)
//enter is keycode number 13

// input.addEventListener("keypress", function(whatEvent){
// 	//so now, whatever key is pressed in the text box is known
// 	//console.log(event);
// 	if (inputLength() > 0 && event.keyCode === 13) {
// 		createListElement();
// 	}
// })


//
//WE CAN EVEN REMOVE THE FUNCTIONS FROM THE EVENT LISTENERS IF WE WANTED TO:
//

function addListAfterClick() {
	if (inputLength() > 0) {
 	createListElement();
	}
}

function addListAfterKeyPress(whatEvent) {
	if (inputLength() > 0 && event.keyCode === 13) {
		createListElement();
	}
}

button.addEventListener("click", addListAfterClick);
input.addEventListener("keypress", addListAfterKeyPress);