using UnityEngine;
using System.Collections;

public class C_GetButton : MonoBehaviour {
void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("xxx");
        }

    }
}
