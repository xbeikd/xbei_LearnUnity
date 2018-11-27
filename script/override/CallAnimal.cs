using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CallAnimal : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Dog dog1 = new Dog();
        //dog1.Age = 25;
        //print(dog1.Age);
        //dog1.Bite();
        //实例化dog对象时候,会先调用父类的构造函数,后调用子类的构造函数
       // Dog dog2 = new Dog();
        //先调用父类无参,再调用dog有参,不调用??
        //Dog dog3 = new Dog(23);
        Animal dog4 = new Dog();


                                //向上转型:将子类对象转为父类对象,子类可以强制转换成父类类型
                                //在使用上,把dog4当做是父类animal类型使用,可以调用animal类所有的字段和方法,但不能调用子类dog类里面的特定方法
                                //特例:如果父类的虚方法在子类中进行了重写,在调用时候可以继续用的啦,和没有强制转换基本没啥区别
                                //来自网路:如果子类中所需要的功能在父类中存在，就使用向上转型

        dog4.Bite();
        //向下转型
        ((Dog)dog4).printDog();//变成父类之后,可以强制转型变回子类使用子类中的方法

        //但是!!!!
        //Animal dog5 = new Animal();
        //Dog newdog = (Dog)dog5; ;//会报错:不能把父类构造器的对象强制转换成子类对象



  
    }

    // Update is called once per frame
    void Update()
    {

    }
}