using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject[] firstgroup;
    public GameObject[] secondgroup;
    public Activator button;
    public Material Transpert;
    public Material normal;

    private void OnTriggerEnter(Collider other) { 
        if (other.CompareTag("Player"))
        {
            foreach(GameObject first in firstgroup) {
                first.GetComponent<Renderer>().material = normal;
                first.GetComponent<Collider>().isTrigger = false;
            }
            foreach (GameObject second in secondgroup)
            {
                second.GetComponent<Renderer>().material = Transpert;
                second.GetComponent<Collider>().isTrigger = true;
            }
            GetComponent<Renderer>().material = Transpert;
            button.GetComponent<Renderer>().material = normal;
        }
    }
}
