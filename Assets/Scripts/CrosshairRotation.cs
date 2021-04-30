using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairRotation : MonoBehaviour
{
    public float sensivity = 5.0f;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CrossHairRotation();
    }

    void CrossHairRotation()
    {
        float mouseInput = Input.GetAxis("Mouse X");
        Vector3 lookhere = new Vector3(0, mouseInput, 0);
        transform.Rotate(lookhere * sensivity);
    }
}
