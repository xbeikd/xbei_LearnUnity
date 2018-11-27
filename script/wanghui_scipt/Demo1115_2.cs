using UnityEngine;
using System.Collections;

public class Demo1115_2 : MonoBehaviour {
    public GameObject m_prifeb_1;
    public Transform m_SpownPoint;
    float Interval;
    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Instantiate(m_prifeb_1, m_SpownPoint.position, Quaternion.identity);
        //}
        //Invoke("Spomn",1);
        Interval += Time.deltaTime;
        if (Interval>1)
        {
            Spomn();
            Interval = 0;

        }
    }
    void Spomn()
    {
            Instantiate(m_prifeb_1, m_SpownPoint.position, Quaternion.identity);
        
    }
    
}
