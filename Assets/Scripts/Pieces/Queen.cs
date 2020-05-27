using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : Piece
{

    private void Awake()
    {

        movement = new QueenMovement();

    }

}
