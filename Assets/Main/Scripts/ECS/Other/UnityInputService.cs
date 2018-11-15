using UnityEngine;

namespace Main.Scripts.ECS.Input
{
    internal class UnityInputService : InputService
    {
        public override float GetAxis(string axisName) => UnityEngine.Input.GetAxis(axisName);

        public override Vector3 MousePosition => UnityEngine.Input.mousePosition;
    }
}