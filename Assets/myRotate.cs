using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myRotate : MonoBehaviour
{
    public float diff = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localRotation *= Quaternion.Euler(0, diff, 0);
    }
}
