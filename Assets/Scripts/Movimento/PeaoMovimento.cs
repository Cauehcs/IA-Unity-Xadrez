using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaoMovimento : Movimento
{

    public override List<Tile> PegarMovimentosValidos() {

        List<Vector2Int> temp = new List<Vector2Int>();
        Vector2Int direcao = PegarDirecao();

        temp.Add(Tabuleiro.instancia.pecaSelecionada.tile.pos + direcao);

        return ValidarExistencia(temp);

    }

    Vector2Int PegarDirecao() {

        if (MaquinaDeEstados.instancia.jogadorAtual.transform.name == "Peças Douradas") return new Vector2Int(0, 1);
        
        else return new Vector2Int(0, -1);

    }

    List<Tile> ValidarExistencia(List<Vector2Int> posicoes) {

        List<Tile> rtv = new List<Tile>();

        foreach (Vector2Int pos in posicoes) {

            Tile tile;

            if (Tabuleiro.instancia.tiles.TryGetValue(pos, out tile)) {

                rtv.Add(tile);

            }

        }

        return rtv;

    }


    List<Tile> LugarBloqueado(List<Tile> posicao) {

        List<Tile> valido = new List<Tile>();

        for (int i = 0; i < posicao.Count; i++) {

            if(posicao[i].conteudo == null) {

                valido.Add(posicao[i]);

            }

        }

        return valido;

    }

}
