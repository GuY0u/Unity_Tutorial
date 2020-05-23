using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_T4 : MonoBehaviour
{
    private BoxCollider col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }


    private void OnTriggerStay(Collider other)
    {
        other.transform.position += new Vector3(0, 0, 0.1f);
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.position = new Vector3(0, 2, 0);
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }
}
