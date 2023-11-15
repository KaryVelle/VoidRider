
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using UnityEngine.SceneManagement;

public class MovementTutorial : MonoBehaviour
{
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

    // Propiedades para la animación del texto
    public float delayBetweenCharacters = 0.1f;
    public AudioSource audioSource;
    public AudioClip typingSound;

    private string fullText;
    private StringBuilder currentText;

    private IEnumerator typingCoroutine;

    public Slider velocity;

    private void Start()
    {
        nextAro.SetActive(true);

        // Configuración inicial de animación de texto
        fullText = instructions.text;
        instructions.text = "";
        currentText = new StringBuilder();

        // Comprueba si hay un audioSource y un sonido de escritura configurados
        if (audioSource && typingSound)
        {
            typingCoroutine = TypeText();
            StartCoroutine(typingCoroutine);
        }
    }

    private void Update()
    {
        // Puedes agregar lógica aquí si necesitas detener la animación de texto antes de que termine.
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            nextAro.SetActive(true);

            if (primeraro)
            {
                velocity.value = 0;
                StartTextAnimation("¡Bien!\nAhora usa los botones para moverte hacia los lados.");
                finger.SetActive(false);
                movementUI.SetActive(true);
            }

            if (segundoAro)
            {
                velocity.value = 0;
                StartTextAnimation("¡Muy Bien!\nAhora usa los botones para subir y bajar");
                upDownButtons.SetActive(true);
            }

            if (tercerAro)
            {
                StartTextAnimation("¡Wow!\nAhora usa el botón debajo del slider.\nEse es tu turbo!");
                turbo.SetActive(true);
            }

            if (aroFinal)
            {
                StartTextAnimation("¡Excelente!\nAhora sabes navegar por el espacio.\nSigamos con tu entrenamiento");
                DelaySceneChanger();
            }
        }
    }

    private void StartTextAnimation(string text)
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
            currentText.Clear();
            instructions.text = fullText;
        }

        fullText = text;
        instructions.text = "";
        typingCoroutine = TypeText();
        StartCoroutine(typingCoroutine);
    }

    private IEnumerator TypeText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText.Append(fullText[i]);
            instructions.text = currentText.ToString();

            if (audioSource && typingSound)
            {
                audioSource.PlayOneShot(typingSound);
            }

            yield return new WaitForSeconds(delayBetweenCharacters);
        }

        if (audioSource)
        {
            audioSource.Stop();
        }

        
    }

    private void DelaySceneChanger()
    {
        SceneManager.LoadScene(2);
    }
}
