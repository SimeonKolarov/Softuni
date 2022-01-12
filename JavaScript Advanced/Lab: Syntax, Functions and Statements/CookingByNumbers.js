function synt(num, firstElement, secondElement, thirdElement, FourthElement, FifthElement){
    if (firstElement == "chop"){
        num /= 2;
        console.log(num);
    } else if (firstElement == "dice"){
        num = Math.sqrt(num);
        console.log(num);
    } else if (firstElement == "spice"){
        num++;
        console.log(num);
    } else if (firstElement == "bake"){
        num *=3;
        console.log(num);
    } else if (firstElement == "fillet"){
        num *= 0.80;
        console.log(Math.round(num * 10) / 10);
    }
     
    if (secondElement == "chop"){
        num /= 2;
        console.log(num);
    } else if (secondElement == "dice"){
        num = Math.sqrt(num);
        console.log(num);
    } else if (secondElement == "spice"){
        num++;
        console.log(num);
    } else if (secondElement == "bake"){
        num *=3;
        console.log(num);
    } else if (secondElement == "fillet"){
        num *= 0.80;
        console.log(Math.round(num * 10) / 10);
    }

    if (thirdElement == "chop"){
        num /= 2;
        console.log(num);
    } else if (thirdElement == "dice"){
        num = Math.sqrt(num);
        console.log(num);
    } else if (thirdElement == "spice"){
        num++;
        console.log(num);
    } else if (thirdElement == "bake"){
        num *=3;
        console.log(num);
    } else if (thirdElement == "fillet"){
        num *= 0.80;
        console.log(Math.round(num * 10) / 10);
    }
    
    if (FourthElement == "chop"){
        num /= 2;
        console.log(num);
    } else if (FourthElement == "dice"){
        num = Math.sqrt(num);
        console.log(num);
    } else if (FourthElement == "spice"){
        num++;
        console.log(num);
    } else if (FourthElement == "bake"){
        num *=3;
        console.log(num);
    } else if (FourthElement == "fillet"){
        num *= 0.80;
        console.log(Math.round(num * 10) / 10);
    }

    if (FifthElement == "chop"){
        num /= 2;
        console.log(num);
    } else if (FifthElement == "dice"){
        num = Math.sqrt(num);
        console.log(num);
    } else if (FifthElement == "spice"){
        num++;
        console.log(num);
    } else if (FifthElement == "bake"){
        num *=3;
        console.log(num);
    } else if (FifthElement == "fillet"){
        num *= 0.80;
        console.log(Math.round(num * 10) / 10);
    }
    
    }
    //synt(32, 'chop', 'chop', 'chop', 'chop', 'chop')
    synt(9, 'dice', 'spice', 'chop', 'bake', 'fillet')
    