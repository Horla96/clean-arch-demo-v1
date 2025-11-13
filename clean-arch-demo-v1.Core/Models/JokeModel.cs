using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_demo_v1.Core.Models
{
    public record JokeModel(string Type, string Setup, string Punchline, int Id);
}
