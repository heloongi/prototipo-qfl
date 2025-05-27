using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    private bool Interagir;
    public string npcID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Oi Vince!");
            }
        }
    }
    
    void Start()
    {
        
    }
    
    void Update()
    {
      
    }
}
