var css = document.querySelector("h3");

var color1 = document.querySelector(".color1");
var color2 = document.querySelector(".color2");

// So anytime the background changes (which is in the body tag) we want to get that info
var body = document.getElementById("gradient");

// console.log(body); (check we are selecting the right element)

//remember we can change the background property with
// body.style.background = "red";


// color1.addEventListener("input", function(){
// 	body.style.background = "linear-gradient(to right, " + color1.value + "," + color2.value + ")";
// 	console.log(color1.value);
// })

// color2.addEventListener("input", function(){
// 	body.style.background = "linear-gradient(to right, " + color1.value + "," + color2.value + ")";
// 	console.log(color2.value);
// })


// BUT DID YOU NOTICE SOMETHING ??? 
// THE CODE IS THE SAME SO WE CAN MAKE A FUNCTION SO WE DON'T DRY

function colorPicker(){
	body.style.background = "linear-gradient(to right, " + color1.value + "," + color2.value + ")";

	//to show the value of the colors
	css.textContent = body.style.background + ";";
}

color1.addEventListener("input", colorPicker);
color2.addEventListener("input", colorPicker);
