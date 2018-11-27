using UnityEngine;
using System.Collections;

public class Demo1115_3 : MonoBehaviour {
    public Transform m_A;
    public Transform m_B;
    float t;
    int dir = 1;
    public float m_speed;
    // Update is called once per frame
    void Update () {
        t += Time.deltaTime * dir * m_speed;
        if (t > 1)
        {
            dir = -1;
            m_speed = Random.Range(0.1f, 0.5f);
        }
        if (t < 0)
        {
            dir = 1;
            m_speed = Random.Range(0.1f, 0.5f);
        }
        transform.position = Vector3.Lerp(m_A.position, m_B.position, t);
       
	}
}
