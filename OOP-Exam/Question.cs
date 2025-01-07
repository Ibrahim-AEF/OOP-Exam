using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Question
    {
            public string Body { get; set; }
            public int Mark { get; set; }
            public List<string> Choices { get; set; }
            public int CorrectAnswer { get; set; }
    }
}
