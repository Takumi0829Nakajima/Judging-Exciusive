using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField] GameObject _replayObject;

    //playPlayer _replayPlayer;
    // Start is called before the first frame update
    void Start()
    {
       //replayPlayer = _replayObject.GetComponent<ReplayPlayer>();
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
            SM.Reload();
        }
    }
}
