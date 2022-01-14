function asg(a){
    let b = a;
    let c = [];
   
  for (let index = 0; index < b.length; index++) {
   
    if (b[index] >= 0){
      let g = b[index].toString();
      c.push(g);
    }
    
    else {
      let v = b[index].toString();
      c.unshift(v);
    }
  }
  
  for (const iterator of c) {
    console.log(iterator);
  }
  
  }
  asg([7, -2, 8, 9])
  asg([3, -2, 0, -1])