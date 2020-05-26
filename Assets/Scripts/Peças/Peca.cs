using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Peca : MonoBehaviour
{
    [HideInInspector]
    public Movimento movimento;
        
    public Tile tile;

    private void OnMouseDown() {

        Tabuleiro.instancia.tileClickado(this, transform.parent.GetComponent<Player>());

    }

}
