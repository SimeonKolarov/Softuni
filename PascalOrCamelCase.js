function solve() {
  
  let text = document.getElementById('text').value;
  let p = document.getElementById('naming-convention').value;
  let result = document.getElementById('result');
  let a = '';
  if (p === 'Camel Case'){
     
    for (let i = 0; i < text.length; i++) {
     
      if (text[i] == ' '){
        a += text[i + 1].toUpperCase();
        i++;
      } else {
        a += text[i];
      }
    }

    result.textContent = a;
  } else if (p === "Pascal Case"){
    for (let i = 0; i < 1; i++) {
     
      a += text[0].toUpperCase();

      for (let j = 1; j < text.length; j++) {
        
        if (text[j] == ' '){
          a += text[j + 1].toUpperCase();
          j++;
        } else {
          a += text[j].toLowerCase();
        }
      }
    }
     
    result.textContent = a;
  } else {
   result.textContent = 'Error!'
  }

}