using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class EstadoFimDeJogo : Estado
{
    public override async void Enter() {

        Debug.Log("Acabou o jogo!");

    }
}
