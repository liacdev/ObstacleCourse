using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = -1;
    private void OnCollisionEnter(Collision other)
   {
        hits++;
        Debug.Log("You scored this many times: " + hits);
   }

}
