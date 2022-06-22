using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField] GameObject _replayObject;
    GameManager gameManager;
    
    //playPlayer _replayPlayer;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //stroy(collision.gameObject, 1.0f);
            //eplayPlayer.CallBall();
            gameManager.Reload();
        }
    }
}
