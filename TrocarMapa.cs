using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocarMapa : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            Application.LoadLevel("Lab");
        }
    }

}
