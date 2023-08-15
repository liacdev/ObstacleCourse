using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveRoller();
    }

    private void moveRoller()
    {
       // This method should move the roller object based on position.
        
        // If roller is in NW position
        if (transform.position.x <= -5.5f && transform.position.z >= 5.5f)
        {
            // Roll -Z
            transform.Translate (0, 0, -moveSpeed * Time.deltaTime);
        }
    
    /*
        // If roller is in NE
        if (transform.position.x >= 5.5f && transform.position.z >= 5.5f)
        {
            // Roll -X
            transform.Translate (-moveSpeed * Time.deltaTime, 0, 0);
        }
       
        // If roller is in SE
        if (transform.position.x >= 5.5f && transform.position.z <= -5.5f)
        {
            // Roll Z
            transform.Translate (0, 0, moveSpeed * Time.deltaTime);
        }
       
        // If roller is in SW
        if (transform.position.x <= -5.5f && transform.position.z <= -5.5f)
        {
            // Roll X
            transform.Translate (moveSpeed * Time.deltaTime, 0, 0);
        }
    */
    }



}
