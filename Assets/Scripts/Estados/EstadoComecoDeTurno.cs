using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class EstadoComecoDeTurno : Estado
{
    
    public override async void Enter() {
        
        Debug.Log("Começo de turno");

        if (maquina.jogadorAtual = maquina.jogador2) maquina.jogadorAtual = maquina.jogador1;
            
            else maquina.jogadorAtual = maquina.jogador2;

        Debug.Log(maquina.jogadorAtual + " está jogando!");

        await Task.Delay(100);

        MaquinaDeEstados.instancia.MudarPara<EstadoSelecionarPeca>();

    }

}
