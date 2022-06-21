using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipController : MonoBehaviour
{
    //public float force = 100.0f;
    //public Vector3 forceDirection = Vector3.forward;
    //public Vector3 offset;

    //[SerializeField] float m_leftMaxLimit = 40f;
    //[SerializeField] float m_leftMinLimit = 0;
    //[SerializeField] float m_rightMaxLimit = 40f;
    //[SerializeField] float m_rightMinLimit = 0;

    //[SerializeField] Rigidbody2D m_leftFliper;
    //[SerializeField] Transform m_leftTarget;

    //[SerializeField] Rigidbody2D m_rightFliper;
    //[SerializeField] Transform m_rightTarget;

    [SerializeField] HingeJoint2D _hingeJointLeft;
    [SerializeField] HingeJoint2D _hingeJointRight;

    // Start is called before the first frame update
    void Start()
    {
        //m_leftFliper.centerOfMass = m_leftTarget.position;
        //m_leftFliper.angularVelocity = 0;

        //m_rightFliper.centerOfMass = m_rightTarget.position;
        //m_rightFliper.angularVelocity = 0;

        //m_leftMaxLimit = m_leftMaxLimit / 180;
        //m_leftMinLimit = m_leftMinLimit / 180;
        //m_rightMaxLimit = m_rightMaxLimit / 180;
        //m_rightMinLimit = m_rightMinLimit / 180;
    }

    // Update is called once per frame
    void Update()
    {
        //bool leftmaxLimit = m_leftFliper.gameObject.transform.localRotation.z < m_leftMaxLimit;
        //bool leftminLimit = m_leftFliper.gameObject.transform.localRotation.z > m_leftMinLimit;
        //bool rightmaxLimit = m_rightFliper.gameObject.transform.localRotation.z > m_rightMaxLimit;
        //bool rightminLimit = m_rightFliper.gameObject.transform.localRotation.z < m_rightMinLimit;
        //if (Input.GetKey(KeyCode.LeftShift) && leftmaxLimit)
        //{
        //    Debug.Log(m_leftFliper.gameObject.transform.localRotation.z);
        //    m_leftFliper.angularVelocity += force;
        //}
        //else if (Input.GetKey(KeyCode.LeftShift) == false && leftminLimit)
        //{
        //    m_leftFliper.angularVelocity -= force;
        //}
        //else
        //{
        //    m_leftFliper.angularVelocity = 0;
        //}

        //if (Input.GetKey(KeyCode.RightShift) && rightmaxLimit)
        //{
        //    m_rightFliper.angularVelocity -= force;
        //}
        //else if (Input.GetKey(KeyCode.RightShift) == false && rightminLimit)
        //{
        //    m_rightFliper.angularVelocity += force;
        //}
        //else
        //{
        //    m_rightFliper.angularVelocity = 0;
        //}


        //丸岡のコード
        //もし左シフトキーが押されたら
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            JointMotor2D motor = _hingeJointLeft.motor;
            motor.motorSpeed *= -1;
            _hingeJointLeft.motor = motor;
        }
        //ここに左シフトキーが離された時の処理を書く
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            JointMotor2D motor = _hingeJointLeft.motor;
            motor.motorSpeed *= -1;
            _hingeJointLeft.motor = motor;
        }

        //もし右シフトキーが押されたら
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            JointMotor2D motor = _hingeJointRight.motor;
            motor.motorSpeed *= -1;
            _hingeJointRight.motor = motor;
        }
        //ここに右シフトキーが離された時の処理を書く
        else if (Input.GetKeyUp(KeyCode.RightShift))
        {
            JointMotor2D motor = _hingeJointRight.motor;
            motor.motorSpeed *= -1;
            _hingeJointRight.motor = motor;
        }
    }
}
