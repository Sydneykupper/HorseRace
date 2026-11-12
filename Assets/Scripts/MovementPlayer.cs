using UnityEngine;

public class cheval : MonoBehaviour
{
    [SerializeField] private float speed = 10.2f;
    [SerializeField] private Rigidbody rbPlayer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
           up arrow key is pressed
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           down arrow key is pressed
        }
        rbPlayer.AddForce(0.0f, 0.0f, speed);
    }
}
