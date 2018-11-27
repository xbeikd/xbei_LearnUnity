using UnityEngine;
using System.Collections;

public class demo1011_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// print("喵喵喵");
		// print("喵喵喵");
		// print("喵喵喵");
		// print("喵喵喵");
		// print("喵喵喵");
		// print("喵喵喵");
		// print("喵喵喵");
		// print("喵喵喵");
		// print("喵喵喵");
		// print("喵喵喵");



		//		print("喵喵喵");
//		for(int i = 0;i<10;i++){
//			print("喵喵喵"+i);
//		}
//		print ("汪汪汪");


		//数组
//		int [] a = new int[]{3,45,23,65,3,65,778,34,54};
//		print (a.Length);
//		for(int i = 0;i<a.Length;i++){
//			print(a [i]);
		//while循环
//		for (int i = 1; i < 10; i++) {
//			print ("for"+i);
//		}
//
//		int num  = 1;
//		while (num < 10) {
//			print (num);
//			num++;
//		}
		//do while 循环
//		int  i = 1;
//		do{
//			print("hah"+i);
//			i++;
//
//		}while(i<10);


//		while (true) {
//			print ("喵喵喵");
//			break;
//		}


		//		foreach循环,主要用于做集合的遍历,比如数组
//		foreach (int t in a) {
//			print(t);
//			
//		}
//		string [] str = new string[3]{"dasd","asdasd","fweg"};
//		foreach (string t in str) {
//				print(t);
//
//			}
		int s  =1 ;
		while (s <= 9){
			if (s == 5) {
				s++;
				continue;
			}
			print(s);

			s++;

	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
