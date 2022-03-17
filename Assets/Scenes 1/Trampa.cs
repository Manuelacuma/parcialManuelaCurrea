using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour {
public GameObject activarTrampa;
public Rigidbody rock;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "carro")
        {
            rock.GetComponent<Rigidbody>().useGravity = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
