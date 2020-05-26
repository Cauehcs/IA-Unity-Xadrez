using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoMoverPeca : Estado
{

    public override async void Enter() {

        Debug.Log(this);

        List<Tile> movimentos = Tabuleiro.instancia.pecaSelecionada.movimento.PegarMovimentosValidos();

        Highlights.instancia.TilesSelecionadas(movimentos);

    }

}
