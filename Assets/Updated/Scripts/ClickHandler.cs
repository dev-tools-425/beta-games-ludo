using UnityEngine;
using UnityEngine.EventSystems;

public class ClickHandler : MonoBehaviour, IPointerClickHandler
{
    public string background;

    public void OnPointerClick(PointerEventData eventData)
    {
        string clickedObj = eventData.pointerCurrentRaycast.gameObject.name;
        Debug.Log("<color=yellow>Clicked </color>" + clickedObj);
        if (clickedObj.Equals(background))
        {
            LoadingPage.Instance.CloseAddMoney();
            LoadingPage.Instance.CloseWithdrawMoney();
        }
    }
}
