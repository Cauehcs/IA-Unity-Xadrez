﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : Piece
{
    
    private void Awake() {
        
        movement = new BishopMovement();

    }

}
