using UnityEngine;
using System.Collections;

public class call_bird : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Bird qw = new Bird();//报错,不能用抽象类构造对象
        Wuaya wuaya = new Wuaya();
        wuaya.Fly();
        
        //可以声明一个抽象类的对象,用子类的构造函数进行构造
        Bird bird = new Wuaya();
        bird.Fly();
        bird.Eat();
        bird.Test();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
