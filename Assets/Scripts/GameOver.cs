using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public BallControl ball;
    Vector2 startPos;
    bool retry;
    bool gameOver;
    public SceneManagement sm;
    public Image black;

    
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
        retry = false;
        gameOver = false;
        black.canvasRenderer.SetAlpha(1);
        Fade();
        StartCoroutine(FadeScreen());     
    }

    IEnumerator FadeScreen()
    {
        yield return new WaitForSeconds(4f);
        black.transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (retry)
        {
            Retry();
        }
        if (gameOver)
        {
            GameEnd();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("True");
            retry = true;
        }
        if (collision.gameObject.tag == "GameOver")
        {
            gameOver = true;
        }
    }

    void Fade()
    {
        black.CrossFadeAlpha(0, 4, true);
       
    }

    void Retry()
    {
        ball.DeActivateRb();
        ball.transform.position = startPos;
        retry = false;
    }

    void GameEnd()
    {
        if (gameOver)
        {
            sm.GameOverScreen();
        }
    }

    public void ExitGame()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
