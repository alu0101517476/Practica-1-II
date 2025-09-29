using UnityEngine;

public class ObjectLogger : MonoBehaviour
{
    void Start()
    {
        // Obtiene todos los objetos activos de la escena
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        foreach (GameObject obj in allObjects)
        {
            // Solo si está activo en la jerarquía y NO está "Untagged"
            if (obj.activeInHierarchy && obj.tag != "Untagged")
            {
                // Muestra en la consola el nombre, tag y posición
                Debug.Log("Objeto: " + obj.name +
                          " | Tag: " + obj.tag +
                          " | Posición: " + obj.transform.position);
            }
        }
    }
}