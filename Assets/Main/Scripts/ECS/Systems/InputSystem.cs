using Unity.Entities;

namespace Main.Scripts.ECS.Input
{
    public class InputSystem : ComponentSystem
    {
        private struct Data
        {
            public readonly int Length;
            public ComponentArray<InputComponent> InputComponents;
        }
    
        [Inject] Data _data;

        protected override void OnUpdate()
        {
            var horizontal = InputService.Instance.GetAxis("Horizontal");
            var vertical = InputService.Instance.GetAxis("Vertical");

            for (var i = 0; i < _data.Length; i++)
            {
                _data.InputComponents[i].Horizontal = horizontal;
                _data.InputComponents[i].Vertical = vertical;
            }
        }
    }
}