using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Peca : MonoBehaviour
{

    public Tile tile;

    private void OnMouseDown() {
    
    }

    private void Start() {
        
        Tabuleiro.instancia.AddPecas(transform.parent.name, this);

    }
}
