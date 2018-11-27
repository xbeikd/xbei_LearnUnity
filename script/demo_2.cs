using UnityEngine;
using System.Collections;

//类的定义:访问控制符 class的类名();
public class Enemy{
    //静态变量的定义
    public static int EnemyCount;   //static 静态对象关键词,整个类共享这一个变量

    // Use this for initialization
    //定义字段:成员变量
    public string name;
    public int age;
    public Enemy()
    {
        name = "aaa";
        age = 24;
        EnemyCount++;
    }
    //定义一个带参数的构造函数
    public Enemy(string n ,int a){
        name = n;
        age = a;
        EnemyCount++;
    }
    public Enemy(string n)
    {
        name = n;
        EnemyCount++;
    }
    //构造函数的定义
    //类中方法的定义

        //构造函数的定义:访问控制符  构造函数名(参数){}
        //构造函数名必须跟类名一致s
    public void Move(){
        Debug.Log(name + "正在移动");

    }
    public void Attack()
    {
        Debug.Log(name+"正在攻击");
    }
    public static int Add(int a ,int b ) {
        return (a + b);
        //静态方法里面只能使用静态变量,不能使用非静态变量
        Debug.Log(EnemyCount);

    }
}
