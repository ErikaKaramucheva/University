package com.example.firstapp

class Jokers {

    fun isEven(num:Int): Boolean {
        if(num%2==0){
            return true;
        }else{
            return false;
        }
    }

    fun isPartOfFibonacci(num:Int):Boolean {
        var f0 = 0;
        var f1 = 1;
        if (num == f0 || num == f1) {
            return true;
        } else {
            var flag = false;
            while (!flag) {
                var temp = f1;
                f1 = f1 + f0;
                if (num == f1) {
                    return true;
                    flag = true;
                } else if (num < f1) {
                    flag = true;
                    return false;
                } else {
                    f0 = temp;
                }
            }
        }
        return false;
    }

    fun digits(num:Int):Int{
        var dig=0;
        var n=num;
        while(n%10>0){
            dig++;
            n/=10;
        }
        return dig;
    }

}
