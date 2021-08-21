using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPaper : MonoBehaviour
{
    public enum Type
    {
        메모,
        편지,
        문서,
        신문,
        기타
    }

    public Type 기록타입;
    public int 기록코드;
    [Header("고정된 게시판같은 곳에서 false로 사용")]
    public bool 획득가능여부;
}
