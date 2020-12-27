using System;
using UnityEngine.EventSystems;


public interface ICustomEventHandler : IEventSystemHandler
{
    void SliderChnage(float position);
}
