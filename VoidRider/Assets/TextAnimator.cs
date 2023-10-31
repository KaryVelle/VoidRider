using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class TextAnimator : MonoBehaviour
{
    public Text textField;
    public float delayBetweenCharacters = 0.1f;
    public AudioSource audioSource;
    public AudioClip typingSound;

    public string fullText;
    public StringBuilder currentText;

    private void Start()
    {
        fullText = textField.text;
        textField.text = "";
        currentText = new StringBuilder();

        StartCoroutine(TypeText());
    }

    public IEnumerator TypeText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText.Append(fullText[i]);
            textField.text = currentText.ToString();
            if (audioSource && typingSound)
            {
                audioSource.PlayOneShot(typingSound);
            }
            yield return new WaitForSeconds(delayBetweenCharacters);
        }
        if (audioSource)
        {
            audioSource.Stop();
            fullText = "";
        }
    }
}
