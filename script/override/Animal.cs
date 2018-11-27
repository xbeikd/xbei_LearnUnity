using UnityEngine;
using System.Collections;

public class Animal
{
    public int Age { get; set; }
    //父类中需要子类重写的方法加上关键字：virtual
    //virtual表示当前的方法可以在子类里重写
    public virtual void Bite()
    {
        Debug.Log("Animal Bite");
    }
    public virtual void GetAge()
    {
        Debug.Log(Age);
    }
    public virtual void BiteMan()
    {
        Debug.Log("Animal Bite Man");
    }

    //构造函数:
    //1,无参的构造函数
    public Animal()
    {
        Debug.Log("animal构造函数");

    }
    //2,带参的构造函数
    public Animal(int age)
    {
        
        Age = age;  //其实就是this.Age = age;的缩写版本,没区别.但是this方法打点时候会编辑器会自动提示候选项,更方便啦!
        Debug.Log("啊啊啊大啦啦");
    }
}
public class Dog : Animal        ////////////子类
{
    //override:子类通过重写父类中的发法实现自身个性化的功能；
    public override void Bite()
    {
        base.Bite();//用base关键词来调用父类的方法,和Java的super方法基本差不多
        Debug.Log("Dog Bite");
    }
    //隐藏父类的xxx方法,用new方法:public new void XXX(){}
    //public new void BitMan()
    //{
    //    Debug.Log("Animal Bite Man");
    //}
    public Dog()
    {
        Debug.Log("dog构造函数");

    }
    public Dog(int age)  :base(age)   //用base可以把父类也调用,否则默认调用子类有参不调用父类有参
    {
        Age = age;
        Debug.Log("狗崽子多大啦啦");
    }
    public void printDog()
    {
        Debug.Log("Dog NYA!");
    }

}
