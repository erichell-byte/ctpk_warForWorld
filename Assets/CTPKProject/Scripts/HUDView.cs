using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDView : MonoBehaviour
{
    [SerializeField] private TMP_Text coinCount;
    [SerializeField] private Image coinImage;
    [SerializeField] private RectTransform coinRectTransform;

    private void Awake()
    {
       GameController.Instance.AddMoneyChangedListeners(ChangeMoneyView);
    }

    private void ChangeMoneyView(int value)
    {
        coinCount.text = value.ToString();
    }

    public Vector3 GetCoinPosition()
    {
        return coinRectTransform.TransformPoint(coinRectTransform.rect.center);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<ITest>();
    }

    public void OnDestroy()
    {
        GameController.Instance.RemoveMoneyChangeListeners(ChangeMoneyView);
    }
}
