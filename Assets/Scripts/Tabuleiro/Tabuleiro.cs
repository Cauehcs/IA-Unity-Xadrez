using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabuleiro : MonoBehaviour
{

    public static Tabuleiro instancia;

    public Dictionary<Vector2Int, Tile> tiles = new Dictionary<Vector2Int, Tile>();

    public List<Peca> pecasDouradas = new List<Peca>();
    public List<Peca> pecasVerdes = new List<Peca>();

    private void Awake() {

        instancia = this;
        
        CriarTabuleiro();

    }

    void CriarTabuleiro() {
        
        for (int i = 0; i < 8; i++) {
        
            for (int j = 0; j < 8; j++) {

                CriarTile(i, j);

            }

        }

    }

    void CriarTile(int i, int j) {

        Tile tile = new Tile();
        tile.pos = new Vector2Int(i, j);
        tiles.Add(tile.pos, tile);

    }

    public void AddPecas(string time, Peca peca) {
        
        Vector2 v2Pos = peca.transform.position;
        Vector2Int position = new Vector2Int((int)v2Pos.x, (int)v2Pos.y);

        peca.tile = tiles[position];
        peca.tile.conteudo = peca;
        
        if(time == "Peças Douradas") {
            
            pecasDouradas.Add(peca);

        }
            else {

                pecasVerdes.Add(peca);

            }

    }

}
