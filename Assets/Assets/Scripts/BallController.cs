using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    /*[SerializeField] float maxForce;//打つ最大の力
    [SerializeField] float chargeSpeed;//1秒間に貯める量

    float chargedForce;//現在貯めている力*/

    GameObject scoreObject;
    // Start is called before the first frame update
    void Start()
    {
        scoreObject = GameObject.Find("ScoerText");
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Point")
        {
            scoreObject.GetComponent<score>().AddScore();
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.Space))
        {
            chargedForce += chargeSpeed * Time.deltaTime;
            if (chargedForce > maxForce)
            {
                Debug.Log("yobareta");
                chargedForce = 0;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, chargedForce), ForceMode2D.Impulse);
            chargedForce = 0f;
        }*/
    }
}
