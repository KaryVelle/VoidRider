using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class ShootTutorial : MonoBehaviour
{
    public GameObject firstEnemy;
    public GameObject secondEnemy;
    public GameObject thirdEnemy;

    public GameObject lastEnemies;
    // Propiedades para la animación del texto
    public float delayBetweenCharacters = 0.1f;
    public AudioSource audioSource;
    public AudioClip typingSound;
    public Text instructions;

    private string fullText;
    private StringBuilder currentText;

    private IEnumerator typingCoroutine;

    private void Start()
    {
        
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
        if (firstEnemy == null)
        {
            StartTextAnimation("¡Eso!\n¡Ahora hay uno justo detras tuyo!\nUsa tus retrovisores y el botón de disparo hacia atrás. ");
            secondEnemy.SetActive(true);
        }
        
        if (secondEnemy == null)
        {
            StartTextAnimation("¡Wow!\nSé que puedes con más, navega hasta el siguiente enemigo y destrúyelo.");
            thirdEnemy.SetActive(true);
        }
        if (thirdEnemy == null)
        { 
            StartTextAnimation("¡Ey!\n¡Vamos por ellos antes de que nuestra vida baje a 0!");
            lastEnemies.SetActive(true);
        }
        if (lastEnemies== null)
        { 
            StartTextAnimation("¡Eso cadete!\n¡Estas listx para embarcarte en esta peligrosa misión...!");
            lastEnemies.SetActive(true);
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
}
