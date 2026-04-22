using UnityEngine;

public class IngredientBehaviour : MonoBehaviour
{
    public Sprite[] minhasImagens;
    public int myID;

public void removerIngrediente(int valor)
{
    IngredientManager.instance.remover(myID, valor);
}

public void adicionarIngrediente(int valor)
{
    IngredientManager.instance.adicionar(myID, valor);
}

void OnMouseDown()
{
    removerIngrediente(1);
        Debug.Log("ID: " + myID + " | Restante: " + IngredientManager.instance.estoque[myID]);
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