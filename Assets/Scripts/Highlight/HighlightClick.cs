using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightClick : MonoBehaviour
{

    public void OnMouseDown() {

        Tabuleiro.instancia.tileClickado(this, null);
            
    }

}
