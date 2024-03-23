using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{   
    
    [SerializeField] private GameObject planetObject;
    [SerializeField] private Vector3 rotationVector;

    private void Update() 
    {
        planetObject.transform.Rotate(rotationVector* Time.deltaTime); 
    }
}
