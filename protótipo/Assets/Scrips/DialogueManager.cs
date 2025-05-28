using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private bool Interagir;
    //public GameObject balao;
    //public Image profile;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player>() != null)
        {
            Interagir = true;
        }
    }
    
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Interagir = true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Oii Vince!!");
            }
            else if (Input.GetKeyUp(KeyCode.E))
            {
                Interagir = false;
            }
        }
    }
    
}
