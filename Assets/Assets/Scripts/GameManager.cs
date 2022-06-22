using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform startPos;
    [SerializeField] GameObject ball;
    [SerializeField] SceneManager sceneManager;
    int remainBall = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reload()
    {
        ball.transform.position = startPos.position;
        remainBall--;

        if (remainBall == 0)
        {
            sceneManager.NextScene("Result");
        }
    }
}
