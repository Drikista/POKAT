using UnityEngine;

public class IngredientBehaviour : MonoBehaviour
{
    public Sprite[] minhasImagens;
    public int myID;

    public int [] estoque;

void awake()
{
for (int i = 0; i < 17; i++)
    {
    estoque[i] = 5;
    }
}

 public void adicionar(int id, int valor)
    {
        estoque[id] += valor;
    }

    public void remover(int id, int valor)
    {
        estoque[id] -= valor;

        if (estoque[id] < 0)
            estoque[id] = 0;
    }

    public void removerIngrediente(int valor)
    {
    this.remover(myID, valor);
    }

    public void adicionarIngrediente(int valor)
    {
    this.adicionar(myID, valor);
    }
public void  atualizaIngrediente(){

SpriteRenderer sr = GetComponent<SpriteRenderer>();
sr.sprite = minhasImagens[myID];

}

    void Start()
    {

        atualizaIngrediente();

    }


}