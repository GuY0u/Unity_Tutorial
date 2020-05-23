using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_T2 : MonoBehaviour
{
    //Vector3 rotation;

    [SerializeField]
    private GameObject go_camera;

    // Start is called before the first frame update
    void Start()
    {
        //rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            ////W클릭시 Z축 값 증가
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;
            //this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);

            ////eulerAngles를 사용한 것
            ////rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            ////this.transform.eulerAngles = rotation;
            ////Debug.Log(transform.eulerAngles);

            ////로테이트를 사용한 것 (위와 동일하다)
            ////this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);

            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.rotation = Quaternion.Euler(rotation);

            //크기 증가
            //this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2) * Time.deltaTime;

            //this.transform.LookAt(go_camera.transform.position);


        }
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
}
