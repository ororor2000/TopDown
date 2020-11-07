using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followTarget;

    public float dampTime = .15f;
    public Vector3 speed = Vector3.zero;
    public float cameraZ = 0;

    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cameraZ = transform.position.z;
        cam = GetComponent<Camera>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (followTarget != null)
        {
            Vector3 delta = followTarget.transform.position - cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, cameraZ));
            Vector3 dest = transform.position + delta;
            dest.z = cameraZ;
            transform.position = Vector3.SmoothDamp(transform.position, dest, ref speed, dampTime);
        }
    }
}
