using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerGage : MonoBehaviour
{
    public Rigidbody2D rb;
    public Slider slider;
    float chargedForce;

    [SerializeField] float maxForce;//�łő�̗�
    [SerializeField] float chargeSpeed;//1�b�Ԃɒ��߂��

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
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
        }

        slider.value = chargedForce;
    }
}
