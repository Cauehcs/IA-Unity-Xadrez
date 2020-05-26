using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlights : MonoBehaviour
{

    public static Highlights instancia;

    public SpriteRenderer highlightsPrefable;

    Queue<SpriteRenderer> highlightsAtivos = new Queue<SpriteRenderer>();
    Queue<SpriteRenderer> highlightsReservas = new Queue<SpriteRenderer>();

    private void Awake() {

        instancia = this;

    }

    public void TilesSelecionadas(List<Tile> tiles) {

        foreach (Tile t in tiles) {

            if (highlightsReservas.Count == 0) CriarHighlight();

            SpriteRenderer sr = highlightsReservas.Dequeue();
            sr.gameObject.SetActive(true);
            sr.color = MaquinaDeEstados.instancia.jogadorAtual.corHighLight;
            sr.transform.position = new Vector3(t.pos.x, t.pos.y, 0);

            highlightsAtivos.Enqueue(sr);

        }

    }

    void CriarHighlight() {

        SpriteRenderer sr = Instantiate(highlightsPrefable, Vector3.zero, Quaternion.identity, transform);
        highlightsReservas.Enqueue(sr);

    }


    [ContextMenu("Deselecionar Peça")] //Opção no menu que permite executar o método. 
    public void DeselecionarPecas() {

        while(highlightsAtivos.Count != 0) {

            SpriteRenderer sr = highlightsAtivos.Dequeue();
            sr.gameObject.SetActive(false);
            
            highlightsReservas.Enqueue(sr);

        }

    }

}
