var database = [
	{
		username: "bob",
		password: "password"
	},
	{
		username: "dragon",
		password: "power"
	},
	{
		username: "seaking",
		password: "sea12"
	}
];

var newsFeed = [
	{
		username: "bob",
		timeline: "bob the builder"
	},
	{
		username: "phoenix",
		timeline: "keyboard"
	},
	{
		username: "aquaman",
		timeline: "king of the sea"
	}
];


var usernamePrompt = prompt("What is your username?");
var passwordPrompt = prompt("What is your password?");

function isUserValid(username, password) {
		for (var i = 0; i < database.length; i++){
		if (database[i].username === usernamePrompt 
			&& database[i].password === passwordPrompt){
			var correct = true;
			return correct;
		} 
	}
	return false;
}

function signIn (username, password) {
		if (isUserValid(username, passwordPrompt)) {
			console.log(newsFeed);
		} else {
			console.log("Sorry wrong username and password");
		}		
}


signIn(usernamePrompt, passwordPrompt);
