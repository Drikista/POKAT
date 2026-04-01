using UnityEngine;
using System.Collections.Generic;

public class Plate : MonoBehaviour
{
    public List<string> requiredIngredients;
    private List<string> currentIngredients = new List<string>();

    public bool AddIngredient(Ingredient_Crunches ingredient)
    {
        if (requiredIngredients.Contains(ingredient.Cebola))
        {
            currentIngredients.Add(ingredient.Cebola);

            Debug.Log("Ingrediente adicionado: " + ingredient.Cebola);
            return true;
        }

        Debug.Log("Ingrediente não necessário");
        return false;
    }
}