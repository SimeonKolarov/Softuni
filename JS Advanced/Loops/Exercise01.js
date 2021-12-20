function solve(list)
{
   let username = list.shift();
   let password = username.split('');
   let passwordAsListReserved = password.reverse();
   let passwordTotal = passwordAsListReserved.join('');
   let n = 0;

  while (true)
  {
    let enterPassword = list.shift();
    
    if (enterPassword == passwordTotal)
    {
        console.log(`User ${username} logged in.`);
        return;
    }

    else 
    {
        console.log('Incorrect password. Try again.');
    }
    n++;

    if (n == 3)
    {
        return;
    }

  }
    
}



solve(['sunny','rainy','cloudy','sunny','not sunny'])