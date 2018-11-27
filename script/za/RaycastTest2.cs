using UnityEngine;
using System.Collections;

public class RaycastTest2 : MonoBehaviour {
    public Transform rayOrigin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(rayOrigin.position,transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
          //  if (hit.point.z > rayOrigin.position.z+2) {
               // print(hit.collider);
                Debug.DrawLine(rayOrigin.position, hit.point, Color.red,2);
         //   }

        }

	}
}
