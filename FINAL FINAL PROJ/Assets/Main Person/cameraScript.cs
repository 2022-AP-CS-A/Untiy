using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{

    public float followSpeed = 2f;
    public float yOffSet = 1f;
    public Transform target;
    public float targetScaleFactor = .5f; 

   
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, (target.position.y * targetScaleFactor) + yOffSet, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed);


    }
}
