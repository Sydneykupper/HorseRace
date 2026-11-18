using UnityEngine;

public class cheval : MonoBehaviour
{
    [SerializeField] private float speed = 10.2f;
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float sidewaysForce = 15f;

    void FixeUdpate()
    {
        rbPlayerr.AddForce(0.0f, 0.0f, speed);
        if (Input.GetKey(KeyCode.Q))
        {
            rbPlayerr.AddForce(-sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rbPlayerr.AddForce(sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
       
    }
}
