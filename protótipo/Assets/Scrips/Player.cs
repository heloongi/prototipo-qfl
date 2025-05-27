using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5;
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
    }
}
