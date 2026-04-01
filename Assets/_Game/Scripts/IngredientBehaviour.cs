using UnityEngine;

public class IngredientBehaviour : MonoBehaviour
{
    public Sprite[] minhasImagens;
    public int myID;


public void  atualizaIngrediente(){

SpriteRenderer sr = GetComponent<SpriteRenderer>();
sr.sprite = minhasImagens[myID];

}

    void Start()
    {

        atualizaIngrediente();
       
       // if (sr != null && myID >= 0 && myID < minhasImagens.Length)
       // {
    
      // }
      //  else
      //  {
      //      Debug.LogWarning("SpriteRenderer não encontrado ou ID inválido");
       // }
    }

}