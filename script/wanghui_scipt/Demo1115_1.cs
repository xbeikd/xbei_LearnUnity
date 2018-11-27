using UnityEngine;
using System.Collections;

public class Demo1115_1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public int m_speedy;
    void Update()
    {
        transform.position += new Vector3(0, -1, 0) * Time.deltaTime * m_speedy;
    }
}
