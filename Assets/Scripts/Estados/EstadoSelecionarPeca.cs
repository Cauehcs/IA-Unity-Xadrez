using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoSelecionarPeca : Estado
{

    public override void Enter() {

        Tabuleiro.instancia.tileClickado += pecaClickada;

    }

    public override void Exit() {

        Tabuleiro.instancia.tileClickado -= pecaClickada;

    }

    void pecaClickada (object sender, object args) {

        Peca peca = sender as Peca;
        Player player = args as Player;

        if(maquina.jogadorAtual == player) {

            Tabuleiro.instancia.pecaSelecionada = peca;
            
            Debug.Log(peca + " foi clickada");

            MaquinaDeEstados.instancia.MudarPara<EstadoMoverPeca>();

        }
        
    }

}
