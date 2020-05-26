using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Estado : MonoBehaviour
{
    protected MaquinaDeEstados maquina { 
        get { return MaquinaDeEstados.instancia; }
    }

    public virtual void Enter() {

    }

    public virtual void Exit() {
        
    }

}
