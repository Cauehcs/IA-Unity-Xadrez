using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeEstados : MonoBehaviour
{
    public static MaquinaDeEstados instancia;

    Estado _atual;
    bool ocupado;

    public Player jogador1;
    public Player jogador2;

    public Player jogadorAtual;

    private void Awake() {
        instancia = this;    
    }

    private void Start() {
        MudarPara<CarregarEstado>();
    }

    public void MudarPara<T>() where T : Estado {

        Estado estado = PegarEstado<T>(); 
            
        if(_atual != estado) MudarEstado(estado);

    }

    public T PegarEstado<T>() where T : Estado {

        T alvo = GetComponent<T>();

        if(alvo == null) {

            alvo = gameObject.AddComponent<T>();

        }

        return alvo;

    }

    void MudarEstado(Estado valor) {

        if (ocupado) return;

        ocupado = true;

        if (_atual != null) _atual.Exit();
        _atual = valor;

        if (_atual != null) _atual.Enter();
        
        ocupado = false;

    }

}
