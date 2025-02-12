using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmenyDestroy : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -4)
        {
            Destroy(gameObject);
        }

    }
}
