using UnityEngine;

public class NextIngredient : MonoBehaviour
{

//criar variavel do objeto com script ingrediente
public IngredientBehaviour Ingrediente;



//associar o objeto
//ja feito


//acessar o script do ingrediente
//quando clica em mim altera para +1 o ID do ingrediente
void OnMouseDown()
   {
    
    Ingrediente.myID++;
    
    
    //base
    if (Ingrediente.myID == 5)
        {
            Ingrediente.myID = 1;
        }
    
    //toppings
    if (Ingrediente.myID == 9)
        {
            Ingrediente.myID = 5;
        }
    
    //proteinas
    if (Ingrediente.myID == 13)
        {
            Ingrediente.myID = 9;
        }


    //crunches
    if (Ingrediente.myID == 17)
        {
            Ingrediente.myID = 13;
        }

    
    Ingrediente.atualizaIngrediente();
   }

//roda o metodo de atualializacao do render que esta ingrente

//obs rodar o +1 e atualizao em um range exe 1-5 depois do 5 volta pro 1
//precisar criar variaveis de range



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IngredientBehaviour IB = GetComponent<IngredientBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
