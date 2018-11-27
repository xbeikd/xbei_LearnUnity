using UnityEngine;
using System.Collections;

public class rigidbodyDemo : MonoBehaviour {

    void Update(){
        if (transform.position.y < -11.325f)
        {
            Destroy(gameObject);

        }
    }
}
