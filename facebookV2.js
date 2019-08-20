
var database = [
	{
		username:"bob",
		password:"good"
	}
];

var newsFeed = [
	{
		username:"yuki",
		timeline:"How you are?"
	},
	{
		username:"Aki",
		timeline:"What are you up to?"
	}
];

var usernamePrompt = prompt("What is your username?");
var passwordPrompt = prompt("What is your password?");

function logIn(user, password) {
	if (user === database[0].username && password === database[0].password) {
		console.log(newsFeed);
	} else {
		alert("Incorrect details");
	}
}

logIn(usernamePrompt, passwordPrompt);

