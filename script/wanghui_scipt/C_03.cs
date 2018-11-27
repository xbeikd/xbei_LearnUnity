using UnityEngine;
using System.Collections;

public class C_03 : MonoBehaviour {
    public Transform t1;
    public Transform t2;
    float t;
    int dir = 1;
    void Update()
    {
        t += Time.deltaTime * dir;
        if (t>1){
            // t = 0;
            dir = -1;
        }
        if (t < 0){
            dir = 1;
        }
        //   transform.position =  Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(5, 5, 0), Time.time*0.1f); 
        transform.position = Vector3.Lerp(t1.position, t2.position,t);
        //Lerp
        if (true)
        {

        }

    }
}
