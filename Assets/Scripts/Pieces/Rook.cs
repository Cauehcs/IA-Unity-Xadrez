﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : Piece
{

    private void Awake()
    {
        movement = new RookMovement();
    }

}
