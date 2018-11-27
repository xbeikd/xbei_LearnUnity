using UnityEngine;
using System.Collections;

public class overload_1 {
    //重载:同一个类中,方法名相同,参数不同,调用方法时根据实参形式的不同匹配相应的方法执行的一种技术
    //参数不用:   1)参数的个数不同,2)参数的类型不同,3)参数的类型顺序不同
    //注意:只是参数名不同不属于重载
    // 重载和方法的返回值类型没有关系
    //多态:重写和抽象方法

    public int Sakura(int a ,int b) {
        return a+b;
        
    }
    public float Sakura(float a ,float b)
    {
        return a + b;
    }
    public string Sakura(string a ,string b)
    {
        return a + b;
    }









}





