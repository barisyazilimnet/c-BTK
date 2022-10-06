// var number1 = Math.random(); //? 0 ile 1 arasında sayı üretir
// var number1 = Math.random() * 49; //? 0 ile 49 arasında sayı üretir
// var number1 = Math.ceil(Math.random() * 49); //? yukarıya yuvarlar
// var number2 = 16;
// var number3 = 3;
// var number4 = 48;
// var number5 = 49;
// var number6 = 11;

// var number1 = Math.ceil(Math.random() * 49);
// var number2 = Math.ceil(Math.random() * 49);
// var number3 = Math.ceil(Math.random() * 49);
// var number4 = Math.ceil(Math.random() * 49);
// var number5 = Math.ceil(Math.random() * 49);
// var number6 = Math.ceil(Math.random() * 49);

// var number1 = Math.ceil(Math.random() * 60);
// var number2 = Math.ceil(Math.random() * 60);
// var number3 = Math.ceil(Math.random() * 60);
// var number4 = Math.ceil(Math.random() * 60);
// var number5 = Math.ceil(Math.random() * 60);
// var number6 = Math.ceil(Math.random() * 60);
// console.log(
//   "Kolon : " +
//     number1 +
//     " " +
//     number2 +
//     " " +
//     number3 +
//     " " +
//     number4 +
//     " " +
//     number5 +
//     " " +
//     number6
// );

// function create_number() {
//   console.log(Math.ceil(Math.random() * 60));
// }
// create_number();

// function create_number() {
//   return Math.ceil(Math.random() * 60);
// }
// var number1 = create_number();
// var number2 = create_number();
// var number3 = create_number();
// var number4 = create_number();
// var number5 = create_number();
// var number6 = create_number();

// function create_number(limit) {
//   return Math.ceil(Math.random() * limit);
// }
// var number1 = create_number(60);
// var number2 = create_number(60);
// var number3 = create_number(60);
// var number4 = create_number(60);
// var number5 = create_number(60);
// var number6 = create_number(60);

function create_number(limit = 49) {
  return Math.ceil(Math.random() * limit);
}
// var number1 = create_number();
// var number2 = create_number();
// var number3 = create_number();
// var number4 = create_number();
// var number5 = create_number();
// var number6 = create_number();

var number1 = create_number(200);
var number2 = create_number();
var number3 = create_number(250);
var number4 = create_number();
var number5 = create_number();
var number6 = create_number(1000);

console.log(
  "Kolon : " +
    number1 +
    " " +
    number2 +
    " " +
    number3 +
    " " +
    number4 +
    " " +
    number5 +
    " " +
    number6
);
