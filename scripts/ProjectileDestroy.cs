using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 4) 
        { 
            Destroy(gameObject);
        }

        if (transform.position.z < -4)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > 6)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -6)
        {
            Destroy(gameObject);
        }
    }
}
