using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject IconeE;
    private bool Interagir;
    //public Collider2D Iris;
    //public GameObject balao;
    //public Image profile;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entrou no trigger!");
        if (other.CompareTag("Player"))
        {
            Debug.Log("O jogador foi avistado!");
            
            if (IconeE != null)
            {
                IconeE.SetActive(true);
                Interagir = true;
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Interagir = false;
            
            if (IconeE != null)
            {
                IconeE.SetActive(false);
            }
        }
    }

    void InteragindoIris()
    {
        Debug.Log("Iniciando diálogo...");
        List<string> dialogo = new List<string>();
        dialogo.Add("Oi Vince!");

        foreach (string linha in dialogo)
        {
            Debug.Log(linha);
        }
    }
    

    void Start()
    {
        if (IconeE != null)
        {
            IconeE.SetActive(false);
        }
    }
    
    void Update()
    {
        if (Interagir && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tecla Espaço pressionada!");
            InteragindoIris();
        }
    }
    
}
