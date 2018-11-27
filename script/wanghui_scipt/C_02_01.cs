using UnityEngine;
using System.Collections;

public class C_02_01 : MonoBehaviour {

    // Use this for initialization
   // public int m_speedx;  //5.0版本后共有变量要加"m_"前缀
    public int m_speedy;
	void Update () {
        //Debug.Log(Input.GetAxis("Vertical"));
        transform.position += new Vector3(0, 1, 0) * Time.deltaTime * m_speedy;
	}
}
