using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

    public float rotationSpeed = 100.0f;
    public float horizantalInput;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizantalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizantalInput);

        if (transform.rotation.y < -90)
        {
            transform.rotation = new Quaternion(transform.rotation.x, Mathf.Clamp(transform.rotation.y, -90f, 90), transform.rotation.z, transform.rotation.w);
        }

        if (transform.rotation.y > 90)
        {
            transform.rotation = new Quaternion(transform.rotation.x, Mathf.Clamp(transform.rotation.y, -90f, 90), transform.rotation.z, transform.rotation.w);
        }
    }
    
    
    
}
