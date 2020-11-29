using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    void Start()
    {

    }
    void OnCollisionEnter(Collision collisionInfo)
    {

       if (collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();
            SceneManager.LoadScene("GameOver");
        }
    }
}
