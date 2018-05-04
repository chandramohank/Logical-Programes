functionion mult(left, rest, index) {
  if (rest.length === index) {
    console.log(left);
    return;
  }
  
  var current = rest[index];
  for(var i = 0; i < current.length; ++i) {
    left.push(current[i]);
    mult(left, rest, index + 1);
    left.pop();
  }
}

var tests = [
  [],
  
  [
    ['a', 'b'],
    ['c', 'd']
  ],
  
  [
    ['a', 'b'],
    ['c', 'd'],
    ['e', 'f']
  ],
  
];

tests.forEach(function(test) {
  mult([], test, 0);
  //0: []
  //1: ["a", "c"] ["a", "d"] ["b", "c"] ["b", "d"]
  //2: ["a", "c", "e"] ["a", "c", "f"]["a", "d", "e"]["a", "d", "f"]["b", "c", "e"]["b", "c", "f"]["b", "d", "e"]["b", "d", "f"]
})