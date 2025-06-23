using UnityEngine;

public class Player : MonoBehaviour
{
    private float Speed = 3;
    private Rigidbody rig;
    
    void Start()
    {
       rig = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = 8;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed = 3;
        }
    }
}
