using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float rotateSpeedX = 1f;
    [SerializeField] float rotateSpeedY = 1f;
    [SerializeField] float rotateSpeedZ= 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (rotateSpeedX, rotateSpeedY, rotateSpeedZ);
    }
}
