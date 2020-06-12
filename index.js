// const person =  {
//     firstName: 'Bob',
//     lastName: 'Smith',
//     fullName() {
//         return `${person.firstName} ${person.lastName}`;
//     }
// };

//using escape key `` (next to the number 1)
// console.log(`Yo, ${person.firstName} ${person.lastName}!`);

// console.log(`Hi, ${person.firstName} ${person.lastName}!`);

// console.log(`Sup, ${person.firstName} ${person.lastName}`);

// console.log(person.fullName());

//issue with above code is read only

const person = {
    firstName: "Black",
    lastName: "Pink",
    get fullName() {
        return `Hello, ${person.firstName} ${person.lastName}`;
    },
    //set keyworkd name of property/method - will take a parameter whic
    //will is the property value on the right side of assignment operator
    set fullName(value) {
        const parts = value.split(' ')
        this.firstName = parts[0];
        this.lastName = parts[1];
    }
};

const song = {
    songName: "Hello World",
    nameChoice: "Test",
    releaseDate: 2000,
    get album() {
        // return `The album you are buying is, ${song.songName} that was released on ${song.releaseDate}`;
        return `Hello, ${song.songName} ${song.releaseDate}`;

    },
    set album(details) {
        const parts = details.split(' ')
        this.songName = parts[0];
        this.releaseDate = parts[1];
    }
    // },
    // set album(nameChoice) {
    //     this.songName = nameChoice;
    //     this.releaseDate = this.releaseDate;
    // }
}
console.log(song.album);
song.album = "dancing power";
console.log(song.album);

//prints to console Black Pink
console.log(person.fullName);

person.fullName = "A Pink";

//prints to console the firstName array[0] and lastName array[1]
console.log(person);

//prints to console Hello, A Pink
console.log(person.fullName);


//better way is below

//getters => access properties in an object


//setter => change(mutate) properties in an object

