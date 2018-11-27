using UnityEngine;
using System.Collections;

public class TimeTest : MonoBehaviour {
    public GameObject cube;
    private float timer;
    private float timer2;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            print("timer <= 0");
            timer = 3.0f;

        }
        timer2 += Time.deltaTime;
        if (timer2 >= 3f)
        {
            print("timer <= 3f");
            timer2 = 0;

        }
        //第一种运动方式
        //cube.transform.position += new Vector3(2*Time.deltaTime,0,0);  //一帧内移一米转换成一秒移动一米//time.datetime可以让变平滑//time.datetime作为计数器
        //第二种运动方式   Translate
        //Vector3:
        // Vector3.zero:等同于new vector(0,0,0);

        //print(Vector3.zero);  //(0,0,0)
        //print(Vector3.right); //(1,0,0);
        //print(Vector3.right);//(-1,0,0);
        cube.transform.Translate(Vector3.right * Time.deltaTime*2);


    }
}
