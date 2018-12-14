using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigDoor : MonoBehaviour
{
    public bool Player1IsTouching = false;
    public bool Player2IsTouching = false;

    private void Update()
    {
       if (Player1IsTouching && Player2IsTouching)
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 1 - collectibles"))

                SceneManager.LoadScene("Level 2 - Damages");

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 2 - Damages"))

                SceneManager.LoadScene("Level 3 - Wall Climbing");

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 3 - Wall Climbing"))

                SceneManager.LoadScene("Level 4 - FallingPlatform");

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 4 - FallingPlatform"))

                SceneManager.LoadScene("Level 5 - Buttons And Switches");

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 5 - Buttons And Switches"))

                SceneManager.LoadScene("Final Level");

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Final Level"))

                SceneManager.LoadScene("Winning"); //WINNING
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player1")
        {
            Player1IsTouching = true;
        }

        if(collision.gameObject.tag == "Player2")
        {
            Player2IsTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player1")
        {
            Player1IsTouching = false;
        }

        if(collision.gameObject.tag == "Player2")
        {
            Player2IsTouching = false;
        }
    }
}