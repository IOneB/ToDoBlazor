using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoBlazor.Data
{
    public class BoolRef
    {
        private bool _value;

        public bool Value { get => _value; set
            {
                _value = value;
                ValueChanged?.Invoke();
                Console.WriteLine(ValueChanged?.GetInvocationList()?.Length);
            }
        }

        public event Action ValueChanged;

        public static implicit operator bool(BoolRef source) => source.Value;
        public static implicit operator BoolRef(bool source) => new BoolRef { Value = source };
    }
}
