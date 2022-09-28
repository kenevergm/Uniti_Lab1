using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("There was a collision with" + other.gameObject.name);
        other.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
    private void OnTriggerExit(Collider other) {
        Debug.Log("Encounter completed with " + other.gameObject.name);
        other.gameObject.GetComponent<Renderer>().material.color = Color.red;

    }
}
