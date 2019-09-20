using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBehavior : MonoBehaviour
{
    public GameObject gameBackground;
    private SpriteRenderer gameBackgroundSpriteRenderer;
    void Start()
    {
        gameBackgroundSpriteRenderer = gameBackground.GetComponent<SpriteRenderer>();
        StartCoroutine(FadeOut(gameBackgroundSpriteRenderer, 0.005f)); //유니티에서 실수형 만들 때 뒤에 f를 붙여줘야함
    }

    IEnumerator FadeOut(SpriteRenderer spriteRenderer, float amount)
    {
        Color color = spriteRenderer.color; //spriteRenderer의 color을 받아와서
        while(color.a > 0.0f) //현재 색의 알파값보다 크다면 = 아직 완전히 투명하지 않는다면
        {
            color.a -= amount;
            spriteRenderer.color = color; //갱신
            yield return new WaitForSeconds(amount); //코루틴 사용. amount만큼 멈췄다가 재실행
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
