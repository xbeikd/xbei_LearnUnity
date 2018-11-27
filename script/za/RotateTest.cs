using UnityEngine;
using System.Collections;

public class RotateTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //获取欧拉角
        print (transform.eulerAngles);
        transform.eulerAngles = new Vector3(34, 52, 26);
        //四元数
        //通过 Quaternion.Euler把欧拉角转成四元数
        transform.rotation = Quaternion.Euler(new Vector3(0, 45, 0));
        print(transform.rotation);
        print(transform.rotation.eulerAngles);//把四元数转换成欧拉角
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
