using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerController movement;
  
    
    void OnCollisionEnter(Collision collisionInfo)
    {

       if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //Debug.Log("Hit it");
            FindObjectOfType<GameManager>().EndGame();


        }
    }
}
