using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class EstadoFimDeTurno : Estado
{
 
    public override async void Enter() {

        Debug.Log("O turno acabou!");

        bool fimDeJogo = VerificarTimes();

        await Task.Delay(100);

        if (fimDeJogo) maquina.MudarPara<EstadoFimDeJogo>();
            else maquina.MudarPara<EstadoComecoDeTurno>();

    }

    bool VerificarTimes() {

        Peca pecaDourada = Tabuleiro.instancia.pecasDouradas.Find((x) => x.gameObject.activeSelf == true);
        Peca pecaVerde = Tabuleiro.instancia.pecasVerdes.Find((x) => x.gameObject.activeSelf == true);

        if(pecaDourada == null) {

            Debug.Log("Lado verde ganhou!");
            return true;

        }

            else if(pecaVerde == null) {
                Debug.Log("Lado dourado ganhou!");
                return true;
            }

        return false;
    }

}
