using UnityEngine;

public class Global
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string [] requiredIngredients = {"Cebola", "Tomate"};
    }

    public static IngredientManager instance;
    void Awake()
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
        {
            estoque[id] = 0;
        }
    }

}
