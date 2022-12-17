using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Image black;


    Camera cam;
    [HideInInspector] public BallControl ball;
    [HideInInspector] public float shootForce = 4f;
    bool isDragging = false;

   
    Vector2 startPoint;
    Vector2 endPoint;
    Vector2 direction;
    Vector2 force;
    float distance;



    void Start()
    {
        cam = Camera.main;
        ball.DeActivateRb();
        black.canvasRenderer.SetAlpha(1);
        FadeScreen();
       
    }

    public void FadeScreen()
    {
        black.CrossFadeAlpha(0, 4, true); 
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            OnDragStart();
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            OnDragEnd();
        }
        if (isDragging)
        {
            OnDrag();
        }
        
       
        
    }


    void OnDragStart()
    {
        ball.DeActivateRb();
        startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnDrag()
    {
        endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        distance = Vector2.Distance(startPoint, endPoint);
        direction = (startPoint - endPoint).normalized;
        force = distance * direction * shootForce;
    }

    void OnDragEnd()
    {
        ball.ActivateRb();
        ball.Shoot(force);


    }

  
}
