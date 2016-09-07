using UnityEngine;
using System.Collections;

public interface IPushable {
    void Push(PushState leftOrRight);
}

public enum PushState
{
    LEFT = 0,
    RIGHT = 1,
    NONE = 2
}
