using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLib.Model
{
    public class Model
    {
        public ReactiveProperty<int> Count { get; set; } = new ReactiveProperty<int>();
    }
}
