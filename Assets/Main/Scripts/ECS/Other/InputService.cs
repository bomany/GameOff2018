using UnityEngine;

namespace Main.Scripts.ECS.Input
{
    public abstract class InputService
    {
        public static InputService Instance
        {
            get => _inputService ?? (_inputService = new UnityInputService());
            set => _inputService = value;
        }

        private static InputService _inputService;

        public abstract float GetAxis(string axisName);

        public abstract Vector3 MousePosition { get; }
    }
}