
using System;
using DG.Tweening;
using UnityEngine;

public class TestCoinPicker : MonoBehaviour
{
    [SerializeField] private HUDView view;
    [SerializeField] private RectTransform coinUIPrefab;
    [SerializeField] private Camera worldCamera;
    [SerializeField] private Camera UICamera;
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            var particleCoin = Instantiate(coinUIPrefab, view.transform);
            particleCoin.transform.position = transform.position;
            var coinPos = CameraUtils.FromWorldToUIPosition(worldCamera, UICamera, view.GetCoinPosition());
            Sequence mySequence = DOTween.Sequence();
            mySequence.Append(particleCoin.DOMove(coinPos, 1f));
            mySequence.AppendCallback(() =>
            {
                GameController.Instance.IncreaseMoney();
                Destroy(particleCoin.gameObject);
                Destroy(gameObject);
            });
        } 
    }
}
