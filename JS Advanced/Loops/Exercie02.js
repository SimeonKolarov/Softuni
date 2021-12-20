function solve(first, second)
{
   let totalSum = 0;
   var s = "";
   for (let i = first; i <= second; i++ )
   {
     s += i + " ";
     totalSum+=i;
   }
    
   console.log(s);
   console.log(`Sum: ${totalSum}`);
}

solve(1, 5);