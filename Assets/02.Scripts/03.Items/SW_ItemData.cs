using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아이템의 타입을 정의하는 열거형(enum)
public enum ItemType
{
    Normal,        // 일반 아이템
    Unique,        // 유니크 아이템
    ImportantMix,  // 중요한단서 용 아이템 조합형
    Important      // 중요한단서 용 아이템
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class SW_ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;   // 아이템의 표시 이름
    public string description;   // 아이템의 설명
    public ItemType type;        // 아이템의 타입
    public Sprite icon;          // 아이템의 아이콘 (UI에 표시될 이미지)
    public GameObject dropPrefab; // 게임 세계에 드롭될 때 사용되는 프리팹

    [Header("Important Item")]
    public Canvas importantItemCanvasPrefab; // 중요한 아이템 UI를 위한 캔버스
    public GameObject importantItemDisplay; // 중요한 아이템을 표시할 UI
}
