using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Test_T21 : MonoBehaviour
{
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] col = Physics.OverlapSphere(transform.position, 10f);

        if(col.Length>0)
        {
            for(int i = 0; i< col.Length; i++)
            {
                Transform tf_target = col[i].transform; 
                if(tf_target.name == "Player")
                {
                    NavMeshPath path = new NavMeshPath();
                    agent.CalculatePath(tf_target.position, path);

                    Vector3[] wayPoints = new Vector3[path.corners.Length + 2];
                    wayPoints[0] = transform.position;
                    wayPoints[wayPoints.Length - 1] = tf_target.position;

                    float _distance = 0f;
                    for(int p =0; p<path.corners.Length; p++)
                    {
                        _distance += Vector3.Distance(wayPoints[p], wayPoints[p + 1]);
                    }

                    if(_distance<=10f)
                    {
                        agent.SetDestination(tf_target.position);
                    }
                }
            }
        }
    }
}
