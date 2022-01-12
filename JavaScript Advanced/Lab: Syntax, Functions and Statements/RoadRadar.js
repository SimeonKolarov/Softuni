function synt(km, way){
    let result;
    if (way == "city"){
        if (km <= 50){
         console.log(`Driving ${km} km/h in a 50 zone`);
        }
        else {
            if (km <= 70){
                result = "speeding";
            }
    
            else if (km <= 90){
                result = "excessive speeding";
            }
    
            else{
                result = "reckless driving";
            }
         console.log(`The speed is ${km - 50} km/h faster than the allowed speed of 50 - ${result}`);
        }
    }
    
    else if (way == "residential"){
        if (km <= 20)
        console.log(`Driving ${km} km/h in a 20 zone`);
         
    else {
        if (km <= 40){
            result = "speeding";
        }
        else if (km <= 60){
            result = "excessive speeding";
        }
        else {
            result = "reckless driving";
        }
         console.log(`The speed is ${km - 20} km/h faster than the allowed speed of 20 - ${result}`);
         }
        }
    
        else if (way == "interstate"){
            if (km <= 90){
                console.log(`Driving ${km} km/h in a 90 zone`);
            }
    
            else {
    
                if (km <= 110){
                    result = "speeding";
                }
                else if (km <= 130){
                    result = "excessive speeding";
                }
                else {
                    result = "reckless driving";
                }
    
                console.log(`The speed is ${km - 90} km/h faster than the allowed speed of 90 - ${result}`);
            }
        }
    
        else if (way == "motorway"){
            if (km <= 130){
                console.log(`Driving ${km} km/h in a 130 zone`);
            }
    
            else {
                if (km <= 150){
                    result = "speeding";
                }
                else if (km <= 170){
                    result = "excessive speeding";
                }
                else {
                    result = "reckless driving";
                }
                console.log(`The speed is ${km - 130} km/h faster than the allowed speed of 130 - ${result}`);
            }
        }
    
    }
    synt(21, 'residential')
    synt(40, 'city')
    synt(120, 'interstate')
    synt(200, 'motorway')