
function calculate (num1:number,num2:number,op:String){
 if (op.charAt(0)=='+'){
     return num1+num2;
 
    }
   else if (op.charAt(0)=='-'){
        return num1-num2;
    }

    else if (op.charAt(0)=='*'){
        return num1*num2;
    }

    else if (op.charAt(0)=='/'){
        if(num2!=0)
        return num1/num2;
        else 
        return 0;
    }
    else {
        return "invalid";
    }
}


let cal=calculate(4,2,"/");
console.log(cal);