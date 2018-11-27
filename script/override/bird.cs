using UnityEngine;
using System.Collections;


//抽象类:class 前面加管家此abstract
//抽象类至少有一个抽象方法,也可以有普通方法
public  abstract class Bird{

    private float speed;
    public float Speed
    {
        get{ return Speed; }
        set{ Speed = value; }
    }
    //定义抽象方法:
    //如果所有的子类都要重写FLY方法,我们将其定位为抽象方法
    //子类必须重写抽象类所有抽象方法
    public abstract void Fly();
    public abstract void Eat();
    public void Test() {
        Debug.Log("sdsdsd");
    }
}
public class Wuaya : Bird
{

    //继承抽象类
    //抽象类适应不完整的模板,
    //子类必须要重写bird抽象类中的所有抽象方法
    public override void Fly()
    {
        Debug.Log("喵喵喵");

    }
    public override void Eat()
    {
        Debug.Log("吃吃吃");

    }
}

