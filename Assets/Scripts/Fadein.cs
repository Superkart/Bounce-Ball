using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadein : MonoBehaviour
{
    public Image whiteFade;
    public Text gameTitle;
    public Text play;
    // Start is called before the first frame update
    void Start()
    {
        whiteFade.canvasRenderer.SetAlpha(0.0f);
        gameTitle.canvasRenderer.SetAlpha(0.0f);
        play.canvasRenderer.SetAlpha(0.0f);
        FadeIn();
    }

   
    void FadeIn()
    {
        whiteFade.CrossFadeAlpha(1, 2, false);
        gameTitle.CrossFadeAlpha(1, 4, false);
        play.CrossFadeAlpha(1, 4, false);
    }

}
