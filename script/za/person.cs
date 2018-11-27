using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Personn
{
    public virtual void sayHell0()
    {
        Debug.Log("父类打招呼的方法");

    }
}
public class chinese : Personn
{
    public override void sayHell0()
    {
        Debug.Log("你好");
    }
}
    public class American : Personn
    {
        public override void sayHell0()
    {
            Debug.Log("hello");
        }
    }
public class Japanese : Personn
{
    public override void sayHell0()
    {
        Debug.Log("こんにちは");
    }
}







