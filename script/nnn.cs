using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemy {
    protected int hp { set; get; }
    protected int speed { set; get; }

    
    public void AI()
    {
        Debug.Log("这里是enemy的AI方法");
    }
    public void Move()
    {
        Debug.Log("这里是enemy的Move方法");
    }

public class Boss : enemy                 //111111111111111111111
    {
        public void attack()
        {
            Debug.Log("Boss正在攻击");
        }

    }
public class type1Enemy : enemy          //222222222222222222222
    {


    }
public class type2Enemy : enemy               //333333333333333333
    {

    }
}
public class Person
{
    public virtual void sayhell0()
    {
        Debug.Log("父类打招呼的方法");

    }
}
