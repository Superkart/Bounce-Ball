using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneManagement : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
       
    }

    public void GameOverScreen()
    {
        SceneManager.LoadScene(2);
    }

    
}
