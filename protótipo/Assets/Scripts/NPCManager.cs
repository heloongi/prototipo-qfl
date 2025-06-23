using UnityEngine;
using System.Collections.Generic;

public abstract class NPCManager
{
    public string npcName;
    public GameObject icone;
    public bool interagir;
    public List<string> dialogo;

    public string NpcName
    {
        get { return this.npcName; }
        set { this.npcName = value; }
    }

    public GameObject Icone
    {
        get { return this.icone; }
        set { this.icone = value; }
    }

    public bool Interagir
    {
        get { return this.interagir; }
        set { this.interagir = value; }
    }

    public List<string> Dialogo
    {
        get { return this.dialogo; }
        set { this.dialogo = value; }
    }

    public NPCManager()
    {
        //vazio
    }

    public NPCManager(string npcName, GameObject icone, bool interagir, List<string> dialogo)
    {
        this.NpcName = npcName;
        this.Icone = icone;
        this.Interagir = interagir;
        this.Dialogo = dialogo;
    }
    
    public abstract void Interacao(bool interagir, List<string> dialogo);

    public abstract void MostrarIconeInteracao(bool interagir);
    
    public abstract void OcultarIconeInteracao(bool interagir);
}
