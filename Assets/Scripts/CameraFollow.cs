using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    //public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void FixedUpdate()
    {
        //probaj si ovo stavit mozda ce bolje funckionirat
        //http://gyanendushekhar.com/2020/03/10/smooth-camera-follow-in-unity-3d/
        //novo
        Vector3 desiredPosition = target.position + offset;
        //Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(desiredPosition.x,desiredPosition.y,transform.position.z);

        transform.LookAt(target);


/*
        //staro
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        //promjenio ovo
        //transform.position = smoothPosition;
        transform.position = new Vector3(smoothPosition.x,smoothPosition.y,transform.position.z);

        transform.LookAt(target);
        */
    }
}
