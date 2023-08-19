using UnityEngine;
using UnityEngine.SceneManagement;


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
                ReloadLevel();
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

    void ReloadLevel()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; 
            SceneManager.LoadScene(currentSceneIndex);
        }





}
