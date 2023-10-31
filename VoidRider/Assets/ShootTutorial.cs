using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using UnityEngine.SceneManagement;


public class ShootTutorial : MonoBehaviour
{
    public GameObject firstEnemy;
    public GameObject secondEnemy;
    public GameObject thirdEnemy;
    public GameObject lastEnemies;

    public bool firstEnemyBool = true;
    public bool secondEnemyBool = true;
    public bool thirdEnemyBool = true;
    public bool lastEnemyBool = true;

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
        if (firstEnemy == null && firstEnemyBool)
        {
            firstEnemyBool = false;
            StartTextAnimation("¡Eso!\n¡Ahora hay uno justo detras tuyo!\nUsa tus retrovisores y el botón de disparo hacia atrás. ");
            secondEnemy.SetActive(true);
        }
        
        if (secondEnemy == null && secondEnemyBool)
        {
            secondEnemyBool = false;
            StartTextAnimation("¡Wow!\nSé que puedes con más, navega hasta el siguiente enemigo y destrúyelo.");
            thirdEnemy.SetActive(true);
        }
        if (thirdEnemy == null && thirdEnemyBool)
        {
            thirdEnemyBool = false;
            StartTextAnimation("¡Ey!\n¡Vamos por ellos antes de que nuestra vida baje a 0!");
            lastEnemies.SetActive(true);
        }
        if (lastEnemies== null && lastEnemyBool)
        { 
            lastEnemyBool = false;
            StartTextAnimation("¡Eso cadete!\n¡Estas listx para embarcarte en esta peligrosa misión...!");
            lastEnemies.SetActive(true);
            StartCoroutine(DelaySceneChange());
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

    private IEnumerator DelaySceneChange()
    {

        yield return new WaitForSeconds(15f);
        SceneManager.LoadScene(0);

    }
}
