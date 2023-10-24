
using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class MovementTutorial : MonoBehaviour
{
    public bool crossed;
    public GameObject nextAro;
    public bool aroFinal;
    public bool primeraro;
    public bool segundoAro;
    public bool tercerAro;
    public GameObject finger;
    public GameObject movementUI;
    public GameObject upDownButtons;
    public GameObject turbo;
    public Text instructions;
    
    private void OnTriggerEnter (Collider other)
    {

        if (other.CompareTag("Player"))
        {
            nextAro.SetActive(true);

            if (primeraro)
            {
                instructions.text = "¡Bien!" +
                                    "Ahora usa los botones para moverte hacia los lados.";
                finger.SetActive(false);
                movementUI.SetActive(true);
            }

            if (segundoAro)
            {
                instructions.text = "¡Muy Bien!" +
                                    "Ahora usa los botones para subir y bajar";
                upDownButtons.SetActive(true);
                
            }

            if (tercerAro)
            {
                instructions.text = "¡Wow!" +
                                    "Ahora usa el botón debajo del slider." +
                                    "Ese es tu turbo!";
               turbo.SetActive(true);
            }

           
            if (aroFinal)
            {
                instructions.text = "¡Excelente!" +
                                    "Ahora sabes navegar por el espacio." +
                                    "Sigamos con tu entrenamiento";
                Debug.Log("fin");
            }
            
        }
    }
}
