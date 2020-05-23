using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_T6 : MonoBehaviour
{
    [SerializeField]
    private GameObject go_Target;

    [SerializeField]
    private float speed;

    private Vector3 difValue;

    // Start is called before the first frame update
    void Start()
    {
        difValue = transform.position - go_Target.transform.position;
        difValue = new Vector3(Mathf.Abs(difValue.x), Mathf.Abs(difValue.y), Mathf.Abs(difValue.z));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, go_Target.transform.position, speed);
    }
}
