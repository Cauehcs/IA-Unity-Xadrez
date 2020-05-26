using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public delegate void EventoTileClickado(object sender, object args);

public class Tabuleiro : MonoBehaviour {

    public static Tabuleiro instancia;

    public Dictionary<Vector2Int, Tile> tiles = new Dictionary<Vector2Int, Tile>();

    public Transform suporteDourado { get { return MaquinaDeEstados.instancia.jogador1.transform; } }
    public Transform suporteVerde { get { return MaquinaDeEstados.instancia.jogador2.transform; } }

    public List<Peca> pecasDouradas = new List<Peca>();
    public List<Peca> pecasVerdes = new List<Peca>();

    public EventoTileClickado tileClickado = delegate{};
    public Peca pecaSelecionada;
    public Highlights HighlightSelecionado;

    private void Awake() {

        instancia = this;

    }

    public async Task Load() {

        PegarTimes();

        await Task.Run(() => CriarTabuleiro());

    }

    void PegarTimes() {

        pecasDouradas.AddRange(suporteDourado.GetComponentsInChildren<Peca>());
        pecasVerdes.AddRange(suporteVerde.GetComponentsInChildren<Peca>());

    }

    public void CriarTabuleiro() {
        
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
      
    }

}
