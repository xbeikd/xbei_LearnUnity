using UnityEngine;
using System.Collections;

public class privateDemo
{
    private int expi;
    //属性的定义
    //public------->都可以访问
    //private----->只有当然类可以访问,其他类和子类不能访问
    //protected------>当前类和子类可以访问,其他类不能访问
    public int Expi{
        //两个访问器,set访问器和get访问器
       
            
        get{//get访问器:读取字段的值 
            return expi;
        }
        
        set{//set访问器:设置字段的值,采用value关键字对字段赋值
        
            expi = value;
        }
        //只有get的就是只读的,只有set就是只能写
    }
    public int healthy { get; set; }//定义属性简化写法//既可读也可写



    //属性定义的一种变形,不是直接控制字段的值
    public int level
    {
        get {
            return (expi / 1000);
}
        set
        {
            expi = value * 1000;
        }
    }

}