using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SW_ItemRead : MonoBehaviour, IInteractable_HT
{
    public GameObject imageBackground; // 이미지 UI에 대한 참조
    public TMPro.TextMeshProUGUI text;
    public GameObject promptText;

    [SerializeField]
    [TextArea]
    private string Info;

    public void OnInteract()
    {
        // 상호작용 시 이미지 UI 활성화
        if (imageBackground != null)
        {
            promptText.SetActive(false);
            imageBackground.SetActive(true);
            text.text = string.Format(Info);
        }
    }

    void Update()
    {
        // 사용자가 배경을 클릭하면 이미지 UI 비활성화
        if (Input.GetMouseButtonDown(0) && imageBackground != null && !RectTransformUtility.RectangleContainsScreenPoint(
            imageBackground.GetComponent<RectTransform>(), Input.mousePosition, Camera.main))
        {
            imageBackground.SetActive(false);
        }
    }
}
