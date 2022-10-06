function createNumber(limit = 50) {
  return Math.ceil(Math.random() * limit);
}

// for (var i = 0; i < 6; i++) {
//     console.log(createNumber());
//   }

for (var i = 1; i <= 8; i++) {
  console.log(i + ". Kolon");
  for (var j = 0; j < 6; j++) {
    console.log(createNumber());
  }
}
