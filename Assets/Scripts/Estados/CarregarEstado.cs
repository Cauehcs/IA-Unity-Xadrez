using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class CarregarEstado : Estado
{

    public override async void Enter() {

        await Tabuleiro.instancia.Load();
        await CarregarTodasAsPecasAsync();

        maquina.jogadorAtual = maquina.jogador2;
        maquina.MudarPara<EstadoComecoDeTurno>();
        
    }

    async Task CarregarTodasAsPecasAsync() {

        CarregarPecaTime(Tabuleiro.instancia.pecasVerdes);
        CarregarPecaTime(Tabuleiro.instancia.pecasDouradas);

        await Task.Delay(100);

    }

    void CarregarPecaTime(List<Peca> peca) {

        foreach (Peca p in peca) {

            Tabuleiro.instancia.AddPecas(p.transform.parent.name, p);

        }

    }


}
