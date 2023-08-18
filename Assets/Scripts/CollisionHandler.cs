using UnityEngine;


public class CollisionHandler : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {

        switch (other.gameObject.tag)
        {
            case "Tower":
                Debug.Log ("Tower");
                break;

            case "Finish":
                Debug.Log ("Finish");
                break;

            case "Dropper":
                Debug.Log ("Dropper");
                break;

            case "Spinner":
                Debug.Log ("Spinner");
                break;

            case "Wall":
                Debug.Log ("Wall");
                break;

            case "Roller":
                Debug.Log ("Roller");
                break;

            case "Hit":
                Debug.Log ("You've hit this before");
                break;

            default:
                Debug.Log ("Crashed");
                break;

        }

    }



}
