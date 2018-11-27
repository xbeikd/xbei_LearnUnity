using UnityEngine;
using System.Collections;

public class Demo1115_1_1 : MonoBehaviour {
    public int m_speed;
	void Update () {

        /////位移的两种方法
        /////第一种:transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * Input.GetAxis("Horizontal") * m_speed);
        /////第二种: transform.Translate(1 * Time.deltaTime * Input.GetAxis("Horizontal") * m_speed, 0, 0);
        //transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * Input.GetAxis("Horizontal") * m_speed);
        //transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * Input.GetAxis("Vertical") * m_speed);
        //transform.Translate(1 * Time.deltaTime * Input.GetAxis("Horizontal") * m_speed, 0, 0);

        transform.Rotate(0,Time.deltaTime * 50 * Input.GetAxis("Horizontal")*m_speed,0);
        transform.Rotate(0, 0, 1 * Input.GetAxis("Vertical") * Time.deltaTime * 50 * m_speed);


    }
}
