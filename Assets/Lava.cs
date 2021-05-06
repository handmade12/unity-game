using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public GameObject Camera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lava")
        {
            this.enabled = false;
            Camera.GetComponent<FirstPersonLook>().enabled = false;
            GetComponent<FirstPersonMovement>().enabled = false;
            GetComponent<Jump>().enabled = false;
            Camera.transform.Rotate(Vector3.left, 90);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
