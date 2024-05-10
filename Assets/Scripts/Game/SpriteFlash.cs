using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlash : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;


    private void Awake()
    {
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    public IEnumerator FlashCoroutine(float flashDuration, Color flashColor, int numberOfFlashes)
    {
        Color startColor = _spriteRenderer.color;
        float elapesedFlashTime = 0;
        float elapesedFlashPercentange = 0;

        while (elapesedFlashTime < flashDuration)
        {
            elapesedFlashTime += Time.deltaTime;
            elapesedFlashPercentange = elapesedFlashTime / flashDuration;

            if (elapesedFlashPercentange > 1)
            {
                elapesedFlashPercentange = 1;
            }

            float pingPongPercentage = Mathf.PingPong(elapesedFlashPercentange * 2 * numberOfFlashes, 1);
            _spriteRenderer.color = Color.Lerp(startColor, flashColor, pingPongPercentage);

            yield return null;

        }

    }
}
