using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SubSelection : MonoBehaviour
{
    public GameObject subObject;
    public GameObject track1;
    public GameObject selectedObject;
    void Start()
    {
        Variables.Object(track1);
    }

    // Update is called once per frame
    void Update()
    {
       subObject = (GameObject)Variables.Object(track1).Get("currentVehiclePrefab");
       Variables.Object(track1).Set("currentVehiclePrefab", selectedObject);
    }
}