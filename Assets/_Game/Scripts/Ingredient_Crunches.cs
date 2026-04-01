using UnityEngine;

public abstract class Ingredient_Crunches : MonoBehaviour
{
    [Header("Configuração")]
    public string Cebola;
    public LayerMask Prato;

    protected Rigidbody rb;
    protected bool isPlaced = false;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }

        rb.useGravity = true;
    }

    protected virtual void Start()
    {
        
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (isPlaced) return;

        // Verifica se colidiu com prato
        if (((1 << collision.gameObject.layer) & Prato) != 0)
        {
            TryPlaceOnPlate(collision);
        }
    }

    protected virtual void TryPlaceOnPlate(Collision collision)
    {
        Plate plate = collision.gameObject.GetComponent<Plate>();

        if (plate != null)
        {
            bool accepted = plate.AddIngredient(this);

            if (accepted)
            {
                PlaceIngredient();
            }
        }
    }

    protected virtual void PlaceIngredient()
    {
        isPlaced = true;

        // Para a física
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.isKinematic = true;

        // Opcional: alinhar melhor no prato
        transform.SetParent(null);
    }
}