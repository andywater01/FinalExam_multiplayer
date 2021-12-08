using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCol : MonoBehaviour
{
    private Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = this.gameObject.transform.Find("Main Camera").gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = cam.position;
    }
}
