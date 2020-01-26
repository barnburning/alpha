using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{

    private Vector3 position;
    private Vector3 end;
    private int l1;
    // Start is called before the first frame update
    void Start()
    {

        position = transform.position;
        end = position + new Vector3(0, 0, 20);
    }

    // Update is called once per frame
    void Update()
    {



        if (transform.position == end) {l1 = 1;} else if (transform.position == position) { l1 = -1; };

        if (l1 == -1)
        {
            transform.position = Vector3.MoveTowards(transform.position, end, 0.12F);
        }

//        if (l1 == 1)
//        {
//            transform.position = Vector3.MoveTowards(transform.position, position, 0.12F);
//        }

    }
}