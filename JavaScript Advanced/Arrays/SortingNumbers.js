function asg(a){
  let b = [];
  let count = 0;
 

  while (a.length > 0) {
    if (count % 2 == 0){
      let min = Math.min.apply(Math, a);
      b.push(min);
      let c = a.indexOf(min);
      a.splice(c, 1);
      count++;
     }
     else {
      let max = Math.max.apply(Math, a);
      b.push(max);
      let c = a.indexOf(max);
      a.splice(c, 1);
      count++;
     }
  }

  console.log(b);
}


asg([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]
)
