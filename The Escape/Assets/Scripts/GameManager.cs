using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

      bool gameHasEnded = false;
      public float restartDelay = 1f;
      public GameObject gameOverPanel;
      public void EndGame()
     {
      if(gameHasEnded == false)
         {
             gameHasEnded = true;
             Debug.Log("Game Over");
            //Invoke("Restart", restartDelay);
             Restart();
         }

      }
        void Update()
        {
            if (gameHasEnded)
            {
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
            }
        }
    public void Restart()
      {
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }

}
