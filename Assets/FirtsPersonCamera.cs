using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstpersoncamera : MonoBehaviour
{
    public GameObject cameraObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation=Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, 2*rotation, 0));
        float rotation1 = Input.GetAxis("Mouse Y");
        cameraObject.transform.Rotate(new Vector3(rotation1, 0, 0));

    }
}
